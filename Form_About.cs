using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CODEVEINPCSaveBackupper
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }

        private void Form_About_Load(object sender, EventArgs e)
        {

            this.Text = Loc.Button_About[Loc.current];

            this.Button_HaoJun0823.Text = Loc.HaoJun0823[Loc.current];

            this.Button_OkamiYuuki.Text = Loc.OkamiYuuki[Loc.current];

            this.Button_Show.Text = Loc.ShowImage[Loc.current];



            switch (Loc.current)
            {

                case 1:
                    this.RichTextBox_Main.Text = Loc.cn_about;
                    break;
                case 2:
                    this.RichTextBox_Main.Text = Loc.tw_about;
                    break;
                default:
                    this.RichTextBox_Main.Text = Loc.en_about;
                    break;
                    

            }



        }

        private void Button_Github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"https://github.com/HaoJun0823/CODEVEIN-PC-Save-Backupper");
        }


        private void Button_HaoJun0823_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"https://blog.haojun0823.xyz/");

        }

        private void Button_OkamiYuuki_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"https://love.okamiyuuki.top/");
        }

        private void Button_Show_Click(object sender, EventArgs e)
        {
            new Backup().Show();
        }

        private void RichTextBox_Main_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
