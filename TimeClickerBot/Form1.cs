using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeClickerBot.Source;

namespace TimeClickerBot
{
    public partial class TimeClickerForm : Form
    {
        public const string Version = "v1.1";

        private readonly GlobalHotKeyHandler hotKeyHandler = new GlobalHotKeyHandler();
        private readonly WorkerHandler workerHandler = new WorkerHandler();
        private readonly ConfigHandler configHandler;

        public TimeClickerForm()
        {
            InitializeComponent();

            hotKeyHandler.Register(Handle, GetType().GetHashCode(), Keys.F6);
            hotKeyHandler.Register(Handle, GetType().GetHashCode(), Keys.F7);
            hotKeyHandler.Register(Handle, GetType().GetHashCode(), Keys.F8);

            configHandler = new ConfigHandler("Data/cf.dat");

            var script = new WorkerScript("Data/NewGameScript.xml");
            script.SequenceDone += (o, k) =>
            {
                configHandler.Load();
                configHandler.TotalTimeLines++;
                configHandler.Save();
            };

            workerHandler.Register("NewGame", script);
            workerHandler.Register("AutoClick", new WorkerAutoClickScript(10));
            workerHandler.Register("AutoBuy", new WorkerScript("Data/AutoBuyScript.xml"));

            StatusLabel.Text = "TimeClickerBot " + Version + " - By Tobias Savinainen";
            Text = "TimeClickerBot " + Version;
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
                        ActivateNewGameScript();
                        break;
                }
            }

            base.WndProc(ref m);
        }

        private void ActivateNewGameScript()
        {
            var enabled = workerHandler.ActivateScript("NewGame");
            
            CurrentScriptLabel.Text = enabled ? "Current Script: New Game (F8)" : "Current Script: None";
            MenuStrip.Enabled = !enabled;
        }

        private void ActivateAutoClickScript()
        {
            var enabled = workerHandler.ActivateScript("AutoClick");
            
            CurrentScriptLabel.Text = enabled ? "Current Script: Auto-Click (F7)" : "Current Script: None";
            MenuStrip.Enabled = !enabled;
        }

        private void ActivateAutoBuyScript()
        {
            var enabled = workerHandler.ActivateScript("AutoBuy");
            
            CurrentScriptLabel.Text = enabled ? "Current Script: Auto-Buy (F6)" : "Current Script: None";
            MenuStrip.Enabled = !enabled;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimeClickerForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) 
                return;

            NotifyIcon.Visible = true;
            ShowInTaskbar = false;
            hotKeyHandler.Reload(Handle, GetType().GetHashCode());
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenApplication();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReloadScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workerHandler.ReloadScript("NewGame", "Data/NewGameScript.xml");
            workerHandler.ReloadScript("AutoBuy", "Data/AutoBuyScript.xml");
        }

        private void EditScriptClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Data\\NewGameScript.xml");
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateNewGameScript();
        }

        private void AutoClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateAutoClickScript();
        }

        private void AutoBuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateAutoBuyScript();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var script = workerHandler.GetScript<WorkerScript>("NewGame");

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
            NotifyIcon.Visible = false;
            hotKeyHandler.Reload(Handle, GetType().GetHashCode());
        }
    }
}
