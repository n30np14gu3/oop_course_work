namespace oop_client
{
    partial class MainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BConnectDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.BStart = new System.Windows.Forms.ToolStripMenuItem();
            this.BStop = new System.Windows.Forms.ToolStripMenuItem();
            this.emulationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LEntityView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientStatus = new System.Windows.Forms.StatusStrip();
            this.TGlobalStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TCurrentHour = new System.Windows.Forms.ToolStripStatusLabel();
            this.TTotalDays = new System.Windows.Forms.ToolStripStatusLabel();
            this.TLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.ClientStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(852, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverSettingsToolStripMenuItem,
            this.BConnectDisconnect,
            this.toolStripMenuItem1,
            this.BStart,
            this.BStop,
            this.emulationSettingsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.clientToolStripMenuItem.Text = "Клиент";
            // 
            // serverSettingsToolStripMenuItem
            // 
            this.serverSettingsToolStripMenuItem.Name = "serverSettingsToolStripMenuItem";
            this.serverSettingsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.serverSettingsToolStripMenuItem.Text = "Сетевые настройки";
            this.serverSettingsToolStripMenuItem.Click += new System.EventHandler(this.serverSettingsToolStripMenuItem_Click);
            // 
            // BConnectDisconnect
            // 
            this.BConnectDisconnect.Name = "BConnectDisconnect";
            this.BConnectDisconnect.Size = new System.Drawing.Size(212, 22);
            this.BConnectDisconnect.Text = "Подключиться к серверу";
            this.BConnectDisconnect.Click += new System.EventHandler(this.BConnectDisconnect_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
            // 
            // BStart
            // 
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(212, 22);
            this.BStart.Text = "Запуск симуляции";
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // BStop
            // 
            this.BStop.Name = "BStop";
            this.BStop.Size = new System.Drawing.Size(212, 22);
            this.BStop.Text = "Остановка симуляции";
            this.BStop.Click += new System.EventHandler(this.BStrop_Click);
            // 
            // emulationSettingsToolStripMenuItem
            // 
            this.emulationSettingsToolStripMenuItem.Name = "emulationSettingsToolStripMenuItem";
            this.emulationSettingsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.emulationSettingsToolStripMenuItem.Text = "Настройки симуляции";
            this.emulationSettingsToolStripMenuItem.Click += new System.EventHandler(this.emulationSettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // LEntityView
            // 
            this.LEntityView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LEntityView.HideSelection = false;
            this.LEntityView.Location = new System.Drawing.Point(12, 27);
            this.LEntityView.Name = "LEntityView";
            this.LEntityView.Size = new System.Drawing.Size(401, 491);
            this.LEntityView.TabIndex = 1;
            this.LEntityView.UseCompatibleStateImageBehavior = false;
            this.LEntityView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID ТУ";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Статус ТУ";
            this.columnHeader2.Width = 302;
            // 
            // ClientStatus
            // 
            this.ClientStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TGlobalStatus,
            this.toolStripStatusLabel1,
            this.TCurrentHour,
            this.TTotalDays});
            this.ClientStatus.Location = new System.Drawing.Point(0, 521);
            this.ClientStatus.Name = "ClientStatus";
            this.ClientStatus.Size = new System.Drawing.Size(852, 22);
            this.ClientStatus.TabIndex = 2;
            this.ClientStatus.Text = "statusStrip1";
            // 
            // TGlobalStatus
            // 
            this.TGlobalStatus.Name = "TGlobalStatus";
            this.TGlobalStatus.Size = new System.Drawing.Size(46, 17);
            this.TGlobalStatus.Text = "Статус:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // TCurrentHour
            // 
            this.TCurrentHour.Name = "TCurrentHour";
            this.TCurrentHour.Size = new System.Drawing.Size(81, 17);
            this.TCurrentHour.Text = "Текущий час:";
            // 
            // TTotalDays
            // 
            this.TTotalDays.Name = "TTotalDays";
            this.TTotalDays.Size = new System.Drawing.Size(70, 17);
            this.TTotalDays.Text = "Всего дней:";
            // 
            // TLog
            // 
            this.TLog.Location = new System.Drawing.Point(419, 54);
            this.TLog.Name = "TLog";
            this.TLog.ReadOnly = true;
            this.TLog.Size = new System.Drawing.Size(421, 464);
            this.TLog.TabIndex = 3;
            this.TLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Лог:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TLog);
            this.Controls.Add(this.ClientStatus);
            this.Controls.Add(this.LEntityView);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "OOP Client";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ClientStatus.ResumeLayout(false);
            this.ClientStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BStart;
        private System.Windows.Forms.ToolStripMenuItem BStop;
        private System.Windows.Forms.ToolStripMenuItem emulationSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView LEntityView;
        private System.Windows.Forms.StatusStrip ClientStatus;
        private System.Windows.Forms.ToolStripStatusLabel TGlobalStatus;
        private System.Windows.Forms.ToolStripStatusLabel TTotalDays;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TCurrentHour;
        private System.Windows.Forms.ToolStripMenuItem BConnectDisconnect;
        private System.Windows.Forms.RichTextBox TLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

