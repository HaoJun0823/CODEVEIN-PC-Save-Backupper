using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CODEVEINPCSaveBackupper
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            
            InitializeComponent();
            BuildListView();

        }

        private void Button_RunningGame_Click(object sender, EventArgs e)
        {
            Config.RunGame();
        }

        private void ListView_SaveData_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem i in this.ListView_SaveData.SelectedItems)
            {
                Console.WriteLine("Select {0}", i.Text);
            }
        }


        private void BuildListView()
        {

            this.ListView_SaveData.BeginUpdate();


            ColumnHeader ch_num = new ColumnHeader();

            ch_num.Text = Loc.ListView_Number[Loc.current];
            ch_num.Width = -2;
            ch_num.TextAlign = HorizontalAlignment.Center;

            ColumnHeader ch_data = new ColumnHeader();

            ch_data.Text = Loc.ListView_Data[Loc.current];
            ch_data.Width = -2;
            ch_data.TextAlign = HorizontalAlignment.Center;

            ColumnHeader ch_date = new ColumnHeader();

            ch_date.Text = Loc.ListView_Date[Loc.current];
            ch_date.Width = -1;
            ch_date.TextAlign = HorizontalAlignment.Center;

            this.ListView_SaveData.Columns.Add(ch_num);
            this.ListView_SaveData.Columns.Add(ch_data);
            this.ListView_SaveData.Columns.Add(ch_date);


            for(int i = 0; i < Config.SaveDataList.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = Convert.ToString(i);

                lvi.SubItems.Add(Config.SaveDataList[i]);
                lvi.SubItems.Add(Config.SaveDateList[i].ToString());

                this.ListView_SaveData.Items.Add(lvi);


            }

            if (this.ListView_SaveData.Items.Count > 0)
            {
                this.ListView_SaveData.Items[0].Selected = true;
            }


            this.ListView_SaveData.EndUpdate();

        }

        private void Button_BackupSaveData_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();


            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+Loc.SaveFolder[Loc.current];

            Console.WriteLine("Backup location:"+path);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Create backup location:" + path);
            }
            else
            {
                Console.WriteLine("Pass create backup location:" + path);
            }


            fbd.SelectedPath = path;

            


            if(fbd.ShowDialog()== DialogResult.OK){

                
                foreach(ListViewItem i in this.ListView_SaveData.SelectedItems)
                {

                    int num = Convert.ToInt32(i.Text);

                    Console.WriteLine("Backup Number:" + num);


                    Config.Backup(fbd.SelectedPath,num);

                    
                }
                

            }

        }

        private void Button_OpenSaveFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Config.CodeVeinDataPath+Config.SaveDataFolderName);
        }

        private void Button_OpenLog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Config.CodeVeinDataPath + Config.LogDataFolderName);
        }

        private void Button_SendBug_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"https://service-en.bandainamcoent.eu/app/ask/p/7492");
        }

        private void Button_Mod_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"https://www.nexusmods.com/codevein");
        }

        private void Button_Config_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Config.CodeVeinDataPath);
        }

        private void Button_OpenDefaultBackupFolder_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Loc.SaveFolder[Loc.current];

            Console.WriteLine("Backup location:" + path);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Create backup location:" + path);
            }
            else
            {
                Console.WriteLine("Pass create backup location:" + path);
            }

            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private void Button_About_Click(object sender, EventArgs e)
        {
            using (Form form = new Form_About())
            {

                form.ShowDialog();

            }
        }

        private void Button_SteamGame_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"https://store.steampowered.com/app/678960/");
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

            this.Text = Loc.Title[Loc.current];
                

            this.Button_RunningGame.Text = Loc.Button_Start[Loc.current];
            this.Button_OpenLog.Text = Loc.Button_Log_Folder[Loc.current];
            this.Button_OpenSaveFolder.Text = Loc.Button_Save_Folder[Loc.current];

            this.Button_SteamGame.Text = Loc.Button_Steam[Loc.current];

            this.Button_Mod.Text = Loc.Button_Nexus[Loc.current];

            this.Button_Config.Text = Loc.Button_Game_Data_Folder[Loc.current];

            this.Button_OpenDefaultBackupFolder.Text = Loc.Button_Backup_Default_Folder[Loc.current];

            this.Button_About.Text = Loc.Button_About[Loc.current];

            this.Button_BackupSaveData.Text = Loc.Button_Backup[Loc.current];

            this.Button_SendBug.Text = Loc.Button_Bandai[Loc.current];

            

        }
    }
}
