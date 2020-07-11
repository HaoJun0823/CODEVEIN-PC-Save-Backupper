using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CODEVEINPCSaveBackupper
{
    class Loc
    {

        public static int current = 0;

        public static String[] SaveFolder = { @"\CodeVeinSaveBackup", @"\噬血代码存档备份", @"\噬血代碼存檔備份" };

        public static String[] ListView_Number = {"Number","序号","序號" };

        public static String[] ListView_Data = { "Steam Account", "Steam帐号", "Steam賬號" };

        public static String[] ListView_Date = { "Last Save Date", "最后保存日期", "最後保存日期" };

        public static String[] Title = { @"CODE VEIN PC Save Backupper",@"噬血代码 存档备份器", @"噬血代碼 存檔備份器" };

        public static String[] Button_Start = { @"Start CODE VEIN(Steam)", @"运行 噬血代码（Steam）", @"運行 噬血代碼（Steam）" };

        public static String[] Button_Backup = { @"Backup Selected Items ", @"备份选中的存档", @"備份選中的存檔" };

        public static String[] Button_Backup_Default_Folder = { @"Open Default Backup Folder ", @"打开默认存档备份目录", @"打開默認存檔備份目錄" };

        public static String[] Button_Save_Folder = { @"Open Save Folder ", @"打开游戏存档目录", @"打開遊戲存檔目錄" };

        public static String[] Button_Log_Folder = { @"Open Log Folder ", @"打开游戏日志目录", @"打開遊戲日誌目錄" };

        public static String[] Button_Game_Data_Folder = { @"Open Game Data Folder ", @"打开游戏数据目录", @"打開遊戲數據目錄" };

        public static String[] Button_Steam = { @"Open Steam Page ", @"打开游戏Steam主页", @"打開遊戲Steam主頁" };

        public static String[] Button_Nexus = { @"Open Nexus Mod Page ", @"打开游戏Nexus模组主页", @"打開遊戲Nexus模組主頁" };

        public static String[] Button_Bandai = { @"Send Email to Bandai", @"给万代发送噬血代码邮件", @"給萬代發送噬血代碼郵件" };

        public static String[] Button_About = { @"About", @"关于", @"關於" };

        public static String[] Auto_Backup = { @"Auto Backup Success", @"自动备份成功", @"自動備份成功" };

        public static String[] Error = { @"Error!", @"错误！", @"" };
        public static String[] Error_Not_Found_Game = { @"Cannot found game user data folder:", @"找不到用户的游戏数据目录：", @"找不到用戶的遊戲數據目錄" };

        public static String[] Success = { @"Success!", @"成功！", @"成功" };

        public static String[] Success_Backup = { @"Success backup save to:", @"成功备份存档于：", @"成功成功備份存檔於：" };

        public static String[] Success_Game = {@"Starting Game", @"游戏即将启动", @"遊戲即將啟動" };

        public static String[] OkamiYuuki = { "Okami Yuuki", "大神佑季", "大神佑季" };

        public static String[] HaoJun0823 = { "Haojun0823's Page", "HaoJun0823的主页", "HaoJun0823的主頁" };

        public static String[] ShowImage = { "Show Image", "显示图像", "顯示圖像" };

        public static String cn_about = @"CODE VEIN PC SAVE BACKUPPER
作者：HaoJun0823

支持语言：英语、简体中文、繁体中文（随着您的操作系统自动切换）

该项目遵循MIT License

使用方式：

主动模式：
直接打开即可。

被动模式：（请无视花括号）
创建一个快捷方式，在其后面添加{ -auto}，运行该快捷方式，即可自动备份存档，然后自动运行游戏。
如果{ -auto}后面追加了一个文件夹路径，例如{ ""D:\backup""}，则自动备份存档到指定路径，然后自动游戏

注：被动模式会有一个屏幕提示。


Github:https://github.com/HaoJun0823/CODEVEIN-PC-Save-Backupper

HaoJun0823.XYZ:https://blog.haojun0823.xyz/
OkamiYuuki.Top:https://love.okamiyuuki.top/
AED.ICU:https://aed.icu/

作者注：我永远喜欢我的儿子大神佑季！";

        public static String en_about = @"CODE VEIN PC SAVE BACKUPPER
Author: HaoJun0823

Supported languages: English, Simplified Chinese, Traditional Chinese(automatically switches with your operating system)

The project follows the MIT License

How to use:

Active mode:
Just open it.

Passive mode: (please ignore braces)
Create a shortcut, add { -auto}
after it, run the shortcut, you can automatically backup and archive, and then automatically run the game.
If a folder path is appended after { -auto}, such as { ""D:\backup""}, then automatically backup and archive to the specified path, and then automatically play

Note: Passive mode will have a screen prompt.


Github: https://github.com/HaoJun0823/CODEVEIN-PC-Save-Backupper

HaoJun0823.XYZ: https://blog.haojun0823.xyz/
OkamiYuuki.Top: https://love.okamiyuuki.top/
AED.ICU:https://aed.icu/

Author's note: Love my son Okami Yuuki forever!";


public static String tw_about = @"CODE VEIN PC SAVE BACKUPPER
作者：HaoJun0823

支持語言：英語、簡體中文、繁體中文（隨著您的操作系統自動切換）

該項目遵循MIT License

使用方式：

主動模式：
直接打開即可。

被動模式：（請無視花括號）
創建一個快捷方式，在其後面添加{ -auto}，運行該快捷方式，即可自動備份存檔，然後自動運行遊戲。
如果{ -auto}後面追加了一個文件夾路徑，例如{ ""D:\backup""}，則自動備份存檔到指定路徑，然後自動遊戲

注：被動模式會有一個屏幕提示。


Github:https://github.com/HaoJun0823/CODEVEIN-PC-Save-Backupper

HaoJun0823.XYZ:https://blog.haojun0823.xyz/
OkamiYuuki.Top:https://love.okamiyuuki.top/
AED.ICU:https://aed.icu/

作者註：我永遠喜歡我的儿子大神佑季！";


        public static String GetBackupTime()
        {

            if (current > 0)
            {
                return DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss.ffff");
            }
            else
            {
                return DateTime.Now.ToString("dd.MM.yyyy-HH.mm.ss.ffff");
            }

            
        }

    }
}
