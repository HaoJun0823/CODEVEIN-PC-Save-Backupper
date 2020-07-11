using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CODEVEINPCSaveBackupper
{
    class Config
    {

        public static String CodeVeinDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CodeVein\Saved\";

        public static String SaveDataFolderName = "SaveGames";

        public static String ConfigDataFolderName = "Config";

        public static String LogDataFolderName = "Logs";

        public static String CrashDataFolderName = "Crashes";

        public static List<String> SaveDataList = new List<String>();
        public static List<DateTime> SaveDateList = new List<DateTime>();

        public static bool ShowUI = true;


        public static String AutoBackupInformation = "";


        
        public static void SetLanguage()
        {
            String cu = System.Globalization.CultureInfo.InstalledUICulture.Name;

            Console.WriteLine("Get Lanuage:" + cu);

            if (cu.ToLower().Equals("zh-cn")||cu.ToLower().Equals("zh-hans"))
            {

                Console.WriteLine("Set Language to ZH-CN");

                Loc.current = 1;

            }else if (cu.Substring(0,2).ToLower().Equals("zh")){


                Console.WriteLine("Set Language to ZH-TW");

                Loc.current = 2;

            }
            else
            {

                Console.WriteLine("Set Language to EN-US");

                Loc.current = 0;

            }



        }

        public static void CheckGameExists()
        {

            if (!Directory.Exists(CodeVeinDataPath))
            {
                MessageBox.Show(Loc.Error_Not_Found_Game[Loc.current]+CodeVeinDataPath,Loc.Error[Loc.current],MessageBoxButtons.OK,MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

        }

        public static void FindSaveData()
        {

            string[] temp = Directory.GetDirectories(CodeVeinDataPath+SaveDataFolderName);
            Console.WriteLine("Try to find:"+CodeVeinDataPath+SaveDataFolderName);

            foreach(var i in temp)
            {

                Console.WriteLine("Get steam account data:"+i);

                string[] filetemp = Directory.GetFiles(i,"*.sav");

                if (filetemp.Length > 0)
                {
                    SaveDataList.Add(Path.GetFileNameWithoutExtension(i));
                    Console.WriteLine("Add {0} to savedata list.", i);

                    DateTime dt = GetFileDate(filetemp[0]);
                    Console.WriteLine("file date:"+dt.ToString());
                    SaveDateList.Add(dt);

                }
                else
                {
                    Console.WriteLine("{0} doesn't have any files.",i);
                }

                

                

                

            }



        }

        public static DateTime GetFileDate(String path)
        {
            Console.WriteLine("Get {0} write time.", path);
            return File.GetLastWriteTime(path);

        }

        public static void RunGame()
        {
            System.Diagnostics.Process.Start("explorer.exe", "steam://rungameid/678960");
        }


        public static String Backup(String path,int i)
        {

            try
            {

                String original_path = CodeVeinDataPath + SaveDataFolderName + @"\" + Config.SaveDataList[i];

                Console.WriteLine("Get original file path {0}.", original_path);

                String[] files = Directory.GetFiles(original_path, "*.sav");

                String target_path = path + @"\" + Config.SaveDataList[i] + "-" + Loc.GetBackupTime();

                Console.WriteLine("Create target folder path {0}.", target_path);

                Directory.CreateDirectory(target_path);



                foreach (var file in files)
                {
                    String filename = Path.GetFileName(file);
                    Console.WriteLine("Copy file {0} to {1}", original_path + @"\" + filename, target_path);
                    File.Copy(original_path + @"\" + filename, target_path + @"\" + filename);
                }


                if (ShowUI) { 

                MessageBox.Show(Loc.Success_Backup[Loc.current] + target_path, Loc.Success[Loc.current], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                }
                return target_path;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(),e.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                
            }

            return null;
        }


    }
}
