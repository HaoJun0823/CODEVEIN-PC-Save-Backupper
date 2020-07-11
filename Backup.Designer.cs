namespace CODEVEINPCSaveBackupper
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.Timer_Main = new System.Windows.Forms.Timer(this.components);
            this.Label_Main = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer_Main
            // 
            this.Timer_Main.Interval = 3000;
            this.Timer_Main.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Label_Main
            // 
            this.Label_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Main.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.Label_Main.ForeColor = System.Drawing.Color.White;
            this.Label_Main.Location = new System.Drawing.Point(0, 0);
            this.Label_Main.Name = "Label_Main";
            this.Label_Main.Size = new System.Drawing.Size(1024, 768);
            this.Label_Main.TabIndex = 2;
            this.Label_Main.Text = "Message";
            this.Label_Main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Main.Click += new System.EventHandler(this.Label_Main_Click_1);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.Label_Main);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer_Main;
        private System.Windows.Forms.Label Label_Main;
    }
}