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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();

            if (!Config.ShowUI) { 

            this.Label_Main.Text = Config.AutoBackupInformation+"\n"+Loc.Success_Game[Loc.current];
             
            }
            else
            {
                this.Label_Main.Text = "";
            }



            int random = new Random().Next(0,100);

            Console.WriteLine("Random:" + random);
            if (random <= 95)
            {
                if (new Random().Next(1, 3) == 2)
                {
                    this.Label_Main.Image = Properties.Resources.Image1;
                }
                else
                {
                    this.Label_Main.Image = Properties.Resources.Image2;
                }
            }
            else
            {
                this.Timer_Main.Interval = 10000;

                if(new Random().Next(1, 3) == 2)
                {
                    this.Label_Main.Image = Properties.Resources.Image_Okami1;
                }
                else
                {
                    this.Label_Main.Image = Properties.Resources.Image_Okami2;
                }
            }


            this.Timer_Main.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label_Main_Click_1(object sender, EventArgs e)
        {

        }
    }
}
