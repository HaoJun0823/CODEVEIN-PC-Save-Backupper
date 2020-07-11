using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CODEVEINPCSaveBackupper
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            





            Config.SetLanguage();

            //Loc.current = 2;

            try
            {
                if (args.Length != 0)
                {
                    int i = Convert.ToInt32(args[0]);
                    i = i < 0 || i > 2 ? 0 : i;
                    Loc.current = i;


                }
            } catch (Exception) { };

            Config.CheckGameExists();
            Config.FindSaveData();



            for(int i=0;i<args.Length;i++)
            {
                if (args[i].ToLower().Trim().Equals("-auto"))
                {

                    Console.WriteLine("Auto Mode");

                    Config.AutoBackupInformation = Loc.Auto_Backup[Loc.current];

                    Config.ShowUI = false;
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Loc.SaveFolder[Loc.current];

                    if (i+1<args.Length)
                    {

                        Console.WriteLine("Check Custom Path:"+args[i+1]);

                        if (args[i + 1].IndexOfAny(Path.GetInvalidPathChars())<0)
                        {

                            Directory.CreateDirectory(args[i + 1]);

                            if (Directory.Exists(args[i + 1]))
                            {
                                path = args[i + 1];
                                Console.WriteLine("Custom Path:" + args[i + 1]);
                                i++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong Custom Path:" + args[i + 1]);
                        }


                    }

                    for (int num = 0; num < Config.SaveDataList.Count; num++) { 
                    string temp = Config.Backup(path,num);

                        Config.AutoBackupInformation = Config.AutoBackupInformation + "\n" + temp;

                    }

                    Config.RunGame();
                    new Backup().ShowDialog();

                    

                }
            }



            if (Config.ShowUI) { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
            }
        }
    }
}
