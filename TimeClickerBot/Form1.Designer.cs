namespace TimeClickerBot
{
    partial class TimeClickerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeClickerForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuStripToolStripOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuToolStripSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuStripToolStripExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeLinesThisSessionLabel = new System.Windows.Forms.Label();
            this.TotalNumberOfTimeLinesLabel = new System.Windows.Forms.Label();
            this.TimeLinesThisSessionValueLabel = new System.Windows.Forms.Label();
            this.TotalNumberOfTimeLinesValueLabel = new System.Windows.Forms.Label();
            this.EstimatedGameTimeLabel = new System.Windows.Forms.Label();
            this.CurrentGameTimeLabel = new System.Windows.Forms.Label();
            this.EstimatedGameTimeValueLabel = new System.Windows.Forms.Label();
            this.CurrentGameTimeValueLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAutoPlayActivate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAutoPlayEditScript = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAutoClickActivateScript = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoBuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAutoBuyActivateScript = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAutoBuyEditScript = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ReloadScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImageFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentScriptLabel = new System.Windows.Forms.Label();
            this.AutoPlayStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.ActiveScriptGroupBox = new System.Windows.Forms.GroupBox();
            this.ContextMenuStripMenu.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.AutoPlayStatsGroupBox.SuspendLayout();
            this.ActiveScriptGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(13, 227);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(215, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.ContextMenuStripMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "TimeClickerBot";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // ContextMenuStripMenu
            // 
            this.ContextMenuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuStripToolStripOpenMenuItem,
            this.ContextMenuToolStripSeperator,
            this.ContextMenuStripToolStripExitMenuItem});
            this.ContextMenuStripMenu.Name = "ContextMenuStrip";
            this.ContextMenuStripMenu.Size = new System.Drawing.Size(188, 54);
            // 
            // ContextMenuStripToolStripOpenMenuItem
            // 
            this.ContextMenuStripToolStripOpenMenuItem.Name = "ContextMenuStripToolStripOpenMenuItem";
            this.ContextMenuStripToolStripOpenMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ContextMenuStripToolStripOpenMenuItem.Text = "Open TimeClickerBot";
            this.ContextMenuStripToolStripOpenMenuItem.Click += new System.EventHandler(this.ContextMenuStripToolStripOpenMenuItem_Click);
            // 
            // ContextMenuToolStripSeperator
            // 
            this.ContextMenuToolStripSeperator.Name = "ContextMenuToolStripSeperator";
            this.ContextMenuToolStripSeperator.Size = new System.Drawing.Size(184, 6);
            // 
            // ContextMenuStripToolStripExitMenuItem
            // 
            this.ContextMenuStripToolStripExitMenuItem.Name = "ContextMenuStripToolStripExitMenuItem";
            this.ContextMenuStripToolStripExitMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ContextMenuStripToolStripExitMenuItem.Text = "Exit";
            this.ContextMenuStripToolStripExitMenuItem.Click += new System.EventHandler(this.ContextMenuStripToolStripExitMenuItem_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 255);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(237, 22);
            this.StatusStrip.TabIndex = 6;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(171, 17);
            this.StatusLabel.Text = "TimeClickerBot - By Tobias Savinainen";
            // 
            // TimeLinesThisSessionLabel
            // 
            this.TimeLinesThisSessionLabel.AutoSize = true;
            this.TimeLinesThisSessionLabel.Location = new System.Drawing.Point(10, 56);
            this.TimeLinesThisSessionLabel.Name = "TimeLinesThisSessionLabel";
            this.TimeLinesThisSessionLabel.Size = new System.Drawing.Size(117, 13);
            this.TimeLinesThisSessionLabel.TabIndex = 7;
            this.TimeLinesThisSessionLabel.Text = "Time lines this session: ";
            // 
            // TotalNumberOfTimeLinesLabel
            // 
            this.TotalNumberOfTimeLinesLabel.AutoSize = true;
            this.TotalNumberOfTimeLinesLabel.Location = new System.Drawing.Point(10, 78);
            this.TotalNumberOfTimeLinesLabel.Name = "TotalNumberOfTimeLinesLabel";
            this.TotalNumberOfTimeLinesLabel.Size = new System.Drawing.Size(136, 13);
            this.TotalNumberOfTimeLinesLabel.TabIndex = 8;
            this.TotalNumberOfTimeLinesLabel.Text = "Total number of time lines:  ";
            // 
            // TimeLinesThisSessionValueLabel
            // 
            this.TimeLinesThisSessionValueLabel.AutoSize = true;
            this.TimeLinesThisSessionValueLabel.Location = new System.Drawing.Point(147, 56);
            this.TimeLinesThisSessionValueLabel.Name = "TimeLinesThisSessionValueLabel";
            this.TimeLinesThisSessionValueLabel.Size = new System.Drawing.Size(13, 13);
            this.TimeLinesThisSessionValueLabel.TabIndex = 9;
            this.TimeLinesThisSessionValueLabel.Text = "0";
            // 
            // TotalNumberOfTimeLinesValueLabel
            // 
            this.TotalNumberOfTimeLinesValueLabel.AutoSize = true;
            this.TotalNumberOfTimeLinesValueLabel.Location = new System.Drawing.Point(147, 78);
            this.TotalNumberOfTimeLinesValueLabel.Name = "TotalNumberOfTimeLinesValueLabel";
            this.TotalNumberOfTimeLinesValueLabel.Size = new System.Drawing.Size(13, 13);
            this.TotalNumberOfTimeLinesValueLabel.TabIndex = 10;
            this.TotalNumberOfTimeLinesValueLabel.Text = "0";
            // 
            // EstimatedGameTimeLabel
            // 
            this.EstimatedGameTimeLabel.AutoSize = true;
            this.EstimatedGameTimeLabel.Location = new System.Drawing.Point(10, 33);
            this.EstimatedGameTimeLabel.Name = "EstimatedGameTimeLabel";
            this.EstimatedGameTimeLabel.Size = new System.Drawing.Size(110, 13);
            this.EstimatedGameTimeLabel.TabIndex = 11;
            this.EstimatedGameTimeLabel.Text = "Estimated game time: ";
            // 
            // CurrentGameTimeLabel
            // 
            this.CurrentGameTimeLabel.AutoSize = true;
            this.CurrentGameTimeLabel.Location = new System.Drawing.Point(10, 10);
            this.CurrentGameTimeLabel.Name = "CurrentGameTimeLabel";
            this.CurrentGameTimeLabel.Size = new System.Drawing.Size(98, 13);
            this.CurrentGameTimeLabel.TabIndex = 12;
            this.CurrentGameTimeLabel.Text = "Current game time: ";
            // 
            // EstimatedGameTimeValueLabel
            // 
            this.EstimatedGameTimeValueLabel.AutoSize = true;
            this.EstimatedGameTimeValueLabel.Location = new System.Drawing.Point(147, 33);
            this.EstimatedGameTimeValueLabel.Name = "EstimatedGameTimeValueLabel";
            this.EstimatedGameTimeValueLabel.Size = new System.Drawing.Size(13, 13);
            this.EstimatedGameTimeValueLabel.TabIndex = 13;
            this.EstimatedGameTimeValueLabel.Text = "0";
            // 
            // CurrentGameTimeValueLabel
            // 
            this.CurrentGameTimeValueLabel.AutoSize = true;
            this.CurrentGameTimeValueLabel.Location = new System.Drawing.Point(147, 10);
            this.CurrentGameTimeValueLabel.Name = "CurrentGameTimeValueLabel";
            this.CurrentGameTimeValueLabel.Size = new System.Drawing.Size(13, 13);
            this.CurrentGameTimeValueLabel.TabIndex = 14;
            this.CurrentGameTimeValueLabel.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CurrentGameTimeLabel);
            this.panel1.Controls.Add(this.TotalNumberOfTimeLinesValueLabel);
            this.panel1.Controls.Add(this.EstimatedGameTimeValueLabel);
            this.panel1.Controls.Add(this.TotalNumberOfTimeLinesLabel);
            this.panel1.Controls.Add(this.TimeLinesThisSessionValueLabel);
            this.panel1.Controls.Add(this.CurrentGameTimeValueLabel);
            this.panel1.Controls.Add(this.EstimatedGameTimeLabel);
            this.panel1.Controls.Add(this.TimeLinesThisSessionLabel);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 101);
            this.panel1.TabIndex = 15;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.scriptToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(237, 24);
            this.MenuStrip.TabIndex = 16;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem,
            this.AutoClickToolStripMenuItem,
            this.AutoBuyToolStripMenuItem,
            this.toolStripSeparator1,
            this.ReloadScriptToolStripMenuItem});
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.scriptToolStripMenuItem.Text = "Script";
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAutoPlayActivate,
            this.ToolStripMenuItemAutoPlayEditScript});
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.NewGameToolStripMenuItem.Text = "Auto-Play (F8)";
            // 
            // ToolStripMenuItemAutoPlayActivate
            // 
            this.ToolStripMenuItemAutoPlayActivate.Name = "ToolStripMenuItemAutoPlayActivate";
            this.ToolStripMenuItemAutoPlayActivate.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemAutoPlayActivate.Text = "Activate script";
            this.ToolStripMenuItemAutoPlayActivate.Click += new System.EventHandler(this.ToolStripMenuItemAutoPlayActivate_Click);
            // 
            // ToolStripMenuItemAutoPlayEditScript
            // 
            this.ToolStripMenuItemAutoPlayEditScript.Name = "ToolStripMenuItemAutoPlayEditScript";
            this.ToolStripMenuItemAutoPlayEditScript.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemAutoPlayEditScript.Text = "Edit script";
            this.ToolStripMenuItemAutoPlayEditScript.Click += new System.EventHandler(this.ToolStripMenuItemAutoPlayEditScript_Click);
            // 
            // AutoClickToolStripMenuItem
            // 
            this.AutoClickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAutoClickActivateScript});
            this.AutoClickToolStripMenuItem.Name = "AutoClickToolStripMenuItem";
            this.AutoClickToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AutoClickToolStripMenuItem.Text = "Auto-Click (F7)";
            // 
            // ToolStripMenuItemAutoClickActivateScript
            // 
            this.ToolStripMenuItemAutoClickActivateScript.Name = "ToolStripMenuItemAutoClickActivateScript";
            this.ToolStripMenuItemAutoClickActivateScript.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemAutoClickActivateScript.Text = "Activate script";
            this.ToolStripMenuItemAutoClickActivateScript.Click += new System.EventHandler(this.ToolStripMenuItemAutoClickActivateScript_Click);
            // 
            // AutoBuyToolStripMenuItem
            // 
            this.AutoBuyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAutoBuyActivateScript,
            this.ToolStripMenuItemAutoBuyEditScript});
            this.AutoBuyToolStripMenuItem.Name = "AutoBuyToolStripMenuItem";
            this.AutoBuyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AutoBuyToolStripMenuItem.Text = "Auto-Buy (F6)";
            // 
            // ToolStripMenuItemAutoBuyActivateScript
            // 
            this.ToolStripMenuItemAutoBuyActivateScript.Name = "ToolStripMenuItemAutoBuyActivateScript";
            this.ToolStripMenuItemAutoBuyActivateScript.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemAutoBuyActivateScript.Text = "Activate script";
            this.ToolStripMenuItemAutoBuyActivateScript.Click += new System.EventHandler(this.ToolStripMenuItemAutoBuyActivateScript_Click);
            // 
            // ToolStripMenuItemAutoBuyEditScript
            // 
            this.ToolStripMenuItemAutoBuyEditScript.Name = "ToolStripMenuItemAutoBuyEditScript";
            this.ToolStripMenuItemAutoBuyEditScript.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenuItemAutoBuyEditScript.Text = "Edit script";
            this.ToolStripMenuItemAutoBuyEditScript.Click += new System.EventHandler(this.ToolStripMenuItemAutoBuyEditScript_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // ReloadScriptToolStripMenuItem
            // 
            this.ReloadScriptToolStripMenuItem.Name = "ReloadScriptToolStripMenuItem";
            this.ReloadScriptToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ReloadScriptToolStripMenuItem.Text = "Reload scripts";
            this.ReloadScriptToolStripMenuItem.Click += new System.EventHandler(this.ReloadScriptToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenImageFolderToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // OpenImageFolderToolStripMenuItem
            // 
            this.OpenImageFolderToolStripMenuItem.Name = "OpenImageFolderToolStripMenuItem";
            this.OpenImageFolderToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.OpenImageFolderToolStripMenuItem.Text = "Open Image Folder";
            this.OpenImageFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenImageFolderToolStripMenuItem_Click);
            // 
            // CurrentScriptLabel
            // 
            this.CurrentScriptLabel.AutoSize = true;
            this.CurrentScriptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CurrentScriptLabel.Location = new System.Drawing.Point(6, 26);
            this.CurrentScriptLabel.Name = "CurrentScriptLabel";
            this.CurrentScriptLabel.Size = new System.Drawing.Size(37, 15);
            this.CurrentScriptLabel.TabIndex = 17;
            this.CurrentScriptLabel.Text = "None";
            // 
            // AutoPlayStatsGroupBox
            // 
            this.AutoPlayStatsGroupBox.Controls.Add(this.panel1);
            this.AutoPlayStatsGroupBox.Location = new System.Drawing.Point(14, 84);
            this.AutoPlayStatsGroupBox.Name = "AutoPlayStatsGroupBox";
            this.AutoPlayStatsGroupBox.Size = new System.Drawing.Size(214, 126);
            this.AutoPlayStatsGroupBox.TabIndex = 18;
            this.AutoPlayStatsGroupBox.TabStop = false;
            this.AutoPlayStatsGroupBox.Text = "Auto-Play Stats";
            // 
            // ActiveScriptGroupBox
            // 
            this.ActiveScriptGroupBox.Controls.Add(this.CurrentScriptLabel);
            this.ActiveScriptGroupBox.Location = new System.Drawing.Point(13, 27);
            this.ActiveScriptGroupBox.Name = "ActiveScriptGroupBox";
            this.ActiveScriptGroupBox.Size = new System.Drawing.Size(214, 51);
            this.ActiveScriptGroupBox.TabIndex = 19;
            this.ActiveScriptGroupBox.TabStop = false;
            this.ActiveScriptGroupBox.Text = "Active script";
            // 
            // TimeClickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 277);
            this.Controls.Add(this.ActiveScriptGroupBox);
            this.Controls.Add(this.AutoPlayStatsGroupBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "TimeClickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeClickerBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeClickerForm_FormClosing);
            this.Resize += new System.EventHandler(this.TimeClickerForm_Resize);
            this.ContextMenuStripMenu.ResumeLayout(false);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.AutoPlayStatsGroupBox.ResumeLayout(false);
            this.ActiveScriptGroupBox.ResumeLayout(false);
            this.ActiveScriptGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Label TimeLinesThisSessionLabel;
        private System.Windows.Forms.Label TotalNumberOfTimeLinesLabel;
        private System.Windows.Forms.Label TimeLinesThisSessionValueLabel;
        private System.Windows.Forms.Label TotalNumberOfTimeLinesValueLabel;
        private System.Windows.Forms.Label EstimatedGameTimeLabel;
        private System.Windows.Forms.Label CurrentGameTimeLabel;
        private System.Windows.Forms.Label EstimatedGameTimeValueLabel;
        private System.Windows.Forms.Label CurrentGameTimeValueLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReloadScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoBuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label CurrentScriptLabel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenImageFolderToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuStripToolStripExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuStripToolStripOpenMenuItem;
        private System.Windows.Forms.ToolStripSeparator ContextMenuToolStripSeperator;
        private System.Windows.Forms.GroupBox AutoPlayStatsGroupBox;
        private System.Windows.Forms.GroupBox ActiveScriptGroupBox;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAutoPlayEditScript;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAutoBuyEditScript;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAutoPlayActivate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAutoClickActivateScript;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAutoBuyActivateScript;
    }
}

