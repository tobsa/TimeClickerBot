using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeClickerBot.Source;

namespace TimeClickerBot
{
    public partial class TimeClickerForm : Form
    {
        public const string Version = "v1.2";

        private readonly GlobalHotKeyHandler hotKeyHandler = new GlobalHotKeyHandler();
        private readonly WorkerScriptHandler scriptHandler = new WorkerScriptHandler();
        private readonly ConfigHandler configHandler;

        private bool reallyClose;

        public TimeClickerForm()
        {
            InitializeComponent();

            hotKeyHandler.Register(Handle, GetType().GetHashCode(), Keys.F6);
            hotKeyHandler.Register(Handle, GetType().GetHashCode(), Keys.F7);
            hotKeyHandler.Register(Handle, GetType().GetHashCode(), Keys.F8);

            configHandler = new ConfigHandler("Data/cf.dat");

            var loader = new ScriptXmlLoader();
            var script = new WorkerScript(loader.Load(ScriptInfo.AutoPlayPath));
            script.Completed += (source, args) =>
            {
                configHandler.Load();
                configHandler.TotalTimeLines++;
                configHandler.Save();
            };

            scriptHandler.Register(ScriptInfo.AutoPlay, script);
            scriptHandler.Register(ScriptInfo.AutoClick, new WorkerAutoClickScript(10));
            scriptHandler.Register(ScriptInfo.AutoBuy, new WorkerScript(loader.Load(ScriptInfo.AutoBuyPath)));

            StatusLabel.Text = "TimeClickerBot " + Version + " - By Tobias Savinainen";
            Text = "TimeClickerBot " + Version;
            Location = new Point() { X = configHandler.StartLocationX, Y = configHandler.StartLocationY };
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == GlobalHotKey.Code)
            {
                switch (GlobalHotKey.GetKey(m))
                {
                    case Keys.F6:
                        ActivateAutoBuyScript();
                        break;
                    case Keys.F7:
                        ActivateAutoClickScript();
                        break;
                    case Keys.F8:
                        ActivateAutoPlayScript();
                        break;
                }
            }

            base.WndProc(ref m);
        }

        private bool ActivateScript(string scriptName, string key)
        {
            var enabled = scriptHandler.ActivateScript(scriptName);

            var enabledText = scriptName + " (" + key + ") is enabled";
            var disabledText = scriptName + " (" + key + ") is disabled";

            NotifyIcon.ShowBalloonTip(1, "", enabled ? enabledText : disabledText, ToolTipIcon.None);

            CurrentScriptLabel.Text = enabled ? "" + scriptName + " (" + key + ")" : "None";
            MenuStrip.Enabled = !enabled;
            CurrentScriptLabel.ForeColor = enabled ? Color.DarkGreen : DefaultForeColor;

            return enabled;
        }

        private void ActivateAutoPlayScript()
        {
            ActivateScript(ScriptInfo.AutoPlay, "F8");
            AutoPlayStatsGroupBox.Enabled = true;
        }

        private void ActivateAutoClickScript()
        {
            var enabled = ActivateScript(ScriptInfo.AutoClick, "F7");

            AutoPlayStatsGroupBox.Enabled = !enabled;
        }

        private void ActivateAutoBuyScript()
        {
            var enabled = ActivateScript(ScriptInfo.AutoBuy, "F6");

            AutoPlayStatsGroupBox.Enabled = !enabled;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            reallyClose = true;
            Application.Exit();
        }

        private void TimeClickerForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) 
                return;

            NotifyIcon.Visible = true;
            ShowInTaskbar = true;
            hotKeyHandler.Reload(Handle, GetType().GetHashCode());
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenApplication();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reallyClose = true;
            Application.Exit();
        }

        private void ReloadScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var loader = new ScriptXmlLoader();
            var script = new WorkerScript(loader.Load(ScriptInfo.AutoPlayPath));
            script.Completed += (source, args) =>
            {
                configHandler.Load();
                configHandler.TotalTimeLines++;
                configHandler.Save();
            };

            configHandler.Load();
            scriptHandler.ReloadScript(ScriptInfo.AutoPlay, script);
            scriptHandler.ReloadScript(ScriptInfo.AutoBuy, new WorkerScript(loader.Load(ScriptInfo.AutoBuyPath)));
        }

        private void ToolStripMenuItemAutoPlayActivate_Click(object sender, EventArgs e)
        {
            ActivateAutoPlayScript();
        }

        private void ToolStripMenuItemAutoClickActivateScript_Click(object sender, EventArgs e)
        {
            ActivateAutoClickScript();
        }

        private void ToolStripMenuItemAutoBuyActivateScript_Click(object sender, EventArgs e)
        {
            ActivateAutoBuyScript();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var script = scriptHandler.GetWorkerScript<WorkerScript>(ScriptInfo.AutoPlay);

            var ms = script.EstimatedTime;
            var estimatedMin = (ms / 1000) / 60;
            var estimatedSec = (ms / 1000) % 60;

            var sessionMin = (script.SessionTime / 1000) / 60;
            var sessionSek = (script.SessionTime / 1000) % 60;

            CurrentGameTimeValueLabel.Text = sessionMin + "m " + sessionSek + "s";
            EstimatedGameTimeValueLabel.Text = estimatedMin + "m " + estimatedSec + "s";
            TimeLinesThisSessionValueLabel.Text = script.TimeLines.ToString();
            TotalNumberOfTimeLinesValueLabel.Text = configHandler.TotalTimeLines.ToString();
        }

        private void OpenImageFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\Data\\Images");
        }

        private void ContextMenuStripToolStripExitMenuItem_Click(object sender, EventArgs e)
        {
            reallyClose = true;
            Application.Exit();
        }

        private void ContextMenuStripToolStripOpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenApplication();
        }

        private void OpenApplication()
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            hotKeyHandler.Reload(Handle, GetType().GetHashCode());
        }

        private void ToolStripMenuItemAutoPlayEditScript_Click(object sender, EventArgs e)
        {
            Process.Start(ScriptInfo.AutoPlayPath.Replace("/", "\\\\"));
        }

        private void ToolStripMenuItemAutoBuyEditScript_Click(object sender, EventArgs e)
        {
            Process.Start(ScriptInfo.AutoBuyPath.Replace("/", "\\\\"));
        }

        private void TimeClickerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reallyClose) 
                return;

            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            hotKeyHandler.Reload(Handle, GetType().GetHashCode());
        }
    }
}
