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
            this.ReloadScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditScriptClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoBuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CurrentScriptLabel = new System.Windows.Forms.Label();
            this.StatusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 192);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(215, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "TimeClickerBot";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
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
            this.StatusStrip.Location = new System.Drawing.Point(0, 222);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(237, 22);
            this.StatusStrip.TabIndex = 6;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(191, 17);
            this.StatusLabel.Text = "TimeClickerBot v1.0 - By Tobias Savinainen";
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
            this.panel1.Location = new System.Drawing.Point(13, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 101);
            this.panel1.TabIndex = 15;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.scriptToolStripMenuItem});
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
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.ReloadScriptToolStripMenuItem,
            this.EditScriptClickToolStripMenuItem});
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.scriptToolStripMenuItem.Text = "Script";
            // 
            // ReloadScriptToolStripMenuItem
            // 
            this.ReloadScriptToolStripMenuItem.Name = "ReloadScriptToolStripMenuItem";
            this.ReloadScriptToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ReloadScriptToolStripMenuItem.Text = "Reload Script";
            this.ReloadScriptToolStripMenuItem.Click += new System.EventHandler(this.ReloadScriptToolStripMenuItem_Click);
            // 
            // EditScriptClickToolStripMenuItem
            // 
            this.EditScriptClickToolStripMenuItem.Name = "EditScriptClickToolStripMenuItem";
            this.EditScriptClickToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.EditScriptClickToolStripMenuItem.Text = "Edit Script";
            this.EditScriptClickToolStripMenuItem.Click += new System.EventHandler(this.EditScriptClickToolStripMenuItem_Click);
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.NewGameToolStripMenuItem.Text = "New Game (F8)";
            this.NewGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // AutoClickToolStripMenuItem
            // 
            this.AutoClickToolStripMenuItem.Name = "AutoClickToolStripMenuItem";
            this.AutoClickToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.AutoClickToolStripMenuItem.Text = "Auto-Click (F7)";
            this.AutoClickToolStripMenuItem.Click += new System.EventHandler(this.AutoClickToolStripMenuItem_Click);
            // 
            // AutoBuyToolStripMenuItem
            // 
            this.AutoBuyToolStripMenuItem.Name = "AutoBuyToolStripMenuItem";
            this.AutoBuyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.AutoBuyToolStripMenuItem.Text = "Auto-Buy (F6)";
            this.AutoBuyToolStripMenuItem.Click += new System.EventHandler(this.AutoBuyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // CurrentScriptLabel
            // 
            this.CurrentScriptLabel.AutoSize = true;
            this.CurrentScriptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CurrentScriptLabel.Location = new System.Drawing.Point(23, 35);
            this.CurrentScriptLabel.Name = "CurrentScriptLabel";
            this.CurrentScriptLabel.Size = new System.Drawing.Size(141, 17);
            this.CurrentScriptLabel.TabIndex = 17;
            this.CurrentScriptLabel.Text = "Current Script : None";
            // 
            // TimeClickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 244);
            this.Controls.Add(this.CurrentScriptLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ExitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "TimeClickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeClickerBot - v1.0";
            this.Resize += new System.EventHandler(this.TimeClickerForm_Resize);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem EditScriptClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoBuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label CurrentScriptLabel;
    }
}

