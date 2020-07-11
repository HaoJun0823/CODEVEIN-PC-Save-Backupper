namespace CODEVEINPCSaveBackupper
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.TabelLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.ListView_SaveData = new System.Windows.Forms.ListView();
            this.TabelLayoutPanel_Extra = new System.Windows.Forms.TableLayoutPanel();
            this.Button_RunningGame = new System.Windows.Forms.Button();
            this.Button_BackupSaveData = new System.Windows.Forms.Button();
            this.Button_About = new System.Windows.Forms.Button();
            this.Button_OpenSaveFolder = new System.Windows.Forms.Button();
            this.Button_OpenLog = new System.Windows.Forms.Button();
            this.Button_SendBug = new System.Windows.Forms.Button();
            this.Button_Config = new System.Windows.Forms.Button();
            this.Button_Mod = new System.Windows.Forms.Button();
            this.Button_OpenDefaultBackupFolder = new System.Windows.Forms.Button();
            this.Button_SteamGame = new System.Windows.Forms.Button();
            this.TabelLayoutPanel_Main.SuspendLayout();
            this.TabelLayoutPanel_Extra.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelLayoutPanel_Main
            // 
            this.TabelLayoutPanel_Main.ColumnCount = 2;
            this.TabelLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TabelLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TabelLayoutPanel_Main.Controls.Add(this.ListView_SaveData, 0, 0);
            this.TabelLayoutPanel_Main.Controls.Add(this.TabelLayoutPanel_Extra, 1, 0);
            this.TabelLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabelLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.TabelLayoutPanel_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabelLayoutPanel_Main.Name = "TabelLayoutPanel_Main";
            this.TabelLayoutPanel_Main.RowCount = 1;
            this.TabelLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabelLayoutPanel_Main.Size = new System.Drawing.Size(584, 461);
            this.TabelLayoutPanel_Main.TabIndex = 0;
            // 
            // ListView_SaveData
            // 
            this.ListView_SaveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView_SaveData.FullRowSelect = true;
            this.ListView_SaveData.GridLines = true;
            this.ListView_SaveData.HideSelection = false;
            this.ListView_SaveData.Location = new System.Drawing.Point(3, 4);
            this.ListView_SaveData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListView_SaveData.Name = "ListView_SaveData";
            this.ListView_SaveData.Size = new System.Drawing.Size(344, 453);
            this.ListView_SaveData.TabIndex = 0;
            this.ListView_SaveData.UseCompatibleStateImageBehavior = false;
            this.ListView_SaveData.View = System.Windows.Forms.View.Details;
            this.ListView_SaveData.SelectedIndexChanged += new System.EventHandler(this.ListView_SaveData_SelectedIndexChanged);
            // 
            // TabelLayoutPanel_Extra
            // 
            this.TabelLayoutPanel_Extra.ColumnCount = 1;
            this.TabelLayoutPanel_Extra.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TabelLayoutPanel_Extra.Controls.Add(this.Button_RunningGame, 0, 0);
            this.TabelLayoutPanel_Extra.Controls.Add(this.Button_BackupSaveData, 0, 1);
            this.TabelLayoutPanel_Extra.Controls.Add(this.Button_About, 0, 9);
            this.TabelLayoutPanel_Extra.Controls.Add(this.Button_OpenSaveFolder, 0, 3);
            this.TabelLayoutPanel_Extra.Controls.Add(this.Button_OpenLog, 0, 4);
            this.TabelLayoutPanel_Extra.Controls.Add(this.Button_SendBug, 0, 8);
            this.TabelLayoutPanel_Extra.Controls.Add(this.Button_Config, 0, 5);
            this.TabelLayoutPanel_Extra.Controls.Add(this.Button_Mod, 0, 7);
            this.TabelLayoutPanel_Extra.Controls.Add(this.Button_OpenDefaultBackupFolder, 0, 2);
            this.TabelLayoutPanel_Extra.Controls.Add(this.Button_SteamGame, 0, 6);
            this.TabelLayoutPanel_Extra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabelLayoutPanel_Extra.Location = new System.Drawing.Point(353, 4);
            this.TabelLayoutPanel_Extra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabelLayoutPanel_Extra.Name = "TabelLayoutPanel_Extra";
            this.TabelLayoutPanel_Extra.RowCount = 10;
            this.TabelLayoutPanel_Extra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelLayoutPanel_Extra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelLayoutPanel_Extra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelLayoutPanel_Extra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelLayoutPanel_Extra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelLayoutPanel_Extra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelLayoutPanel_Extra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelLayoutPanel_Extra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelLayoutPanel_Extra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelLayoutPanel_Extra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TabelLayoutPanel_Extra.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TabelLayoutPanel_Extra.Size = new System.Drawing.Size(228, 453);
            this.TabelLayoutPanel_Extra.TabIndex = 0;
            // 
            // Button_RunningGame
            // 
            this.Button_RunningGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_RunningGame.Location = new System.Drawing.Point(3, 4);
            this.Button_RunningGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_RunningGame.Name = "Button_RunningGame";
            this.Button_RunningGame.Size = new System.Drawing.Size(222, 37);
            this.Button_RunningGame.TabIndex = 1;
            this.Button_RunningGame.Text = "Start Game";
            this.Button_RunningGame.UseVisualStyleBackColor = true;
            this.Button_RunningGame.Click += new System.EventHandler(this.Button_RunningGame_Click);
            // 
            // Button_BackupSaveData
            // 
            this.Button_BackupSaveData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_BackupSaveData.Location = new System.Drawing.Point(3, 49);
            this.Button_BackupSaveData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_BackupSaveData.Name = "Button_BackupSaveData";
            this.Button_BackupSaveData.Size = new System.Drawing.Size(222, 37);
            this.Button_BackupSaveData.TabIndex = 2;
            this.Button_BackupSaveData.Text = "Backup Choice";
            this.Button_BackupSaveData.UseVisualStyleBackColor = true;
            this.Button_BackupSaveData.Click += new System.EventHandler(this.Button_BackupSaveData_Click);
            // 
            // Button_About
            // 
            this.Button_About.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_About.Location = new System.Drawing.Point(3, 409);
            this.Button_About.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_About.Name = "Button_About";
            this.Button_About.Size = new System.Drawing.Size(222, 40);
            this.Button_About.TabIndex = 10;
            this.Button_About.Text = "About";
            this.Button_About.UseVisualStyleBackColor = true;
            this.Button_About.Click += new System.EventHandler(this.Button_About_Click);
            // 
            // Button_OpenSaveFolder
            // 
            this.Button_OpenSaveFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_OpenSaveFolder.Location = new System.Drawing.Point(3, 139);
            this.Button_OpenSaveFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_OpenSaveFolder.Name = "Button_OpenSaveFolder";
            this.Button_OpenSaveFolder.Size = new System.Drawing.Size(222, 37);
            this.Button_OpenSaveFolder.TabIndex = 4;
            this.Button_OpenSaveFolder.Text = "Open Save Folder";
            this.Button_OpenSaveFolder.UseVisualStyleBackColor = true;
            this.Button_OpenSaveFolder.Click += new System.EventHandler(this.Button_OpenSaveFolder_Click);
            // 
            // Button_OpenLog
            // 
            this.Button_OpenLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_OpenLog.Location = new System.Drawing.Point(3, 184);
            this.Button_OpenLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_OpenLog.Name = "Button_OpenLog";
            this.Button_OpenLog.Size = new System.Drawing.Size(222, 37);
            this.Button_OpenLog.TabIndex = 5;
            this.Button_OpenLog.Text = "Open Log Folder";
            this.Button_OpenLog.UseVisualStyleBackColor = true;
            this.Button_OpenLog.Click += new System.EventHandler(this.Button_OpenLog_Click);
            // 
            // Button_SendBug
            // 
            this.Button_SendBug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_SendBug.Location = new System.Drawing.Point(3, 364);
            this.Button_SendBug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_SendBug.Name = "Button_SendBug";
            this.Button_SendBug.Size = new System.Drawing.Size(222, 37);
            this.Button_SendBug.TabIndex = 9;
            this.Button_SendBug.Text = "Send Email to Bandai";
            this.Button_SendBug.UseVisualStyleBackColor = true;
            this.Button_SendBug.Click += new System.EventHandler(this.Button_SendBug_Click);
            // 
            // Button_Config
            // 
            this.Button_Config.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Config.Location = new System.Drawing.Point(3, 229);
            this.Button_Config.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Config.Name = "Button_Config";
            this.Button_Config.Size = new System.Drawing.Size(222, 37);
            this.Button_Config.TabIndex = 6;
            this.Button_Config.Text = "Open Game Data Folder";
            this.Button_Config.UseVisualStyleBackColor = true;
            this.Button_Config.Click += new System.EventHandler(this.Button_Config_Click);
            // 
            // Button_Mod
            // 
            this.Button_Mod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Mod.Location = new System.Drawing.Point(3, 319);
            this.Button_Mod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Mod.Name = "Button_Mod";
            this.Button_Mod.Size = new System.Drawing.Size(222, 37);
            this.Button_Mod.TabIndex = 8;
            this.Button_Mod.Text = "Open Nexus Mod";
            this.Button_Mod.UseVisualStyleBackColor = true;
            this.Button_Mod.Click += new System.EventHandler(this.Button_Mod_Click);
            // 
            // Button_OpenDefaultBackupFolder
            // 
            this.Button_OpenDefaultBackupFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_OpenDefaultBackupFolder.Location = new System.Drawing.Point(3, 94);
            this.Button_OpenDefaultBackupFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_OpenDefaultBackupFolder.Name = "Button_OpenDefaultBackupFolder";
            this.Button_OpenDefaultBackupFolder.Size = new System.Drawing.Size(222, 37);
            this.Button_OpenDefaultBackupFolder.TabIndex = 3;
            this.Button_OpenDefaultBackupFolder.Text = "Open Default Backup Folder";
            this.Button_OpenDefaultBackupFolder.UseVisualStyleBackColor = true;
            this.Button_OpenDefaultBackupFolder.Click += new System.EventHandler(this.Button_OpenDefaultBackupFolder_Click);
            // 
            // Button_SteamGame
            // 
            this.Button_SteamGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_SteamGame.Location = new System.Drawing.Point(3, 274);
            this.Button_SteamGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_SteamGame.Name = "Button_SteamGame";
            this.Button_SteamGame.Size = new System.Drawing.Size(222, 37);
            this.Button_SteamGame.TabIndex = 7;
            this.Button_SteamGame.Text = "Open Steam Page";
            this.Button_SteamGame.UseVisualStyleBackColor = true;
            this.Button_SteamGame.Click += new System.EventHandler(this.Button_SteamGame_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.TabelLayoutPanel_Main);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CODEVEIN PC Save Backupper";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.TabelLayoutPanel_Main.ResumeLayout(false);
            this.TabelLayoutPanel_Extra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabelLayoutPanel_Main;
        private System.Windows.Forms.ListView ListView_SaveData;
        private System.Windows.Forms.TableLayoutPanel TabelLayoutPanel_Extra;
        private System.Windows.Forms.Button Button_RunningGame;
        private System.Windows.Forms.Button Button_BackupSaveData;
        private System.Windows.Forms.Button Button_About;
        private System.Windows.Forms.Button Button_OpenSaveFolder;
        private System.Windows.Forms.Button Button_OpenLog;
        private System.Windows.Forms.Button Button_SendBug;
        private System.Windows.Forms.Button Button_Config;
        private System.Windows.Forms.Button Button_Mod;
        private System.Windows.Forms.Button Button_OpenDefaultBackupFolder;
        private System.Windows.Forms.Button Button_SteamGame;
    }
}

