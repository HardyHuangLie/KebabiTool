using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using IWS = IWshRuntimeLibrary;

namespace Kebabi
{
    internal class ShortCut
    {
        static string FileName = "Kebabi";
        static string exePath = System.Windows.Forms.Application.ExecutablePath;
        static string deskTop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
        public static bool IsDesktopShortcut()
        {
            return System.IO.File.Exists(deskTop + FileName + ".lnk");
        }
        public static void CreateDesktopShortcut()
        {
            try
            {
                if (System.IO.File.Exists(deskTop + FileName + ".lnk"))  //
                {
                    System.IO.File.Delete(deskTop + FileName + ".lnk");//刪除原來的桌面快捷鍵方式
                }
                IWS.WshShell shell = new IWS.WshShell();

                //快捷鍵方式建立的位置、名稱
                IWS.IWshShortcut shortcut = (IWS.IWshShortcut)shell.CreateShortcut(deskTop + FileName + ".lnk");
                shortcut.TargetPath = exePath; //目標檔案
                                               //該屬性指定應用程式的工作目錄，當用戶沒有指定一個具體的目錄時，快捷方式的目標應用程式將使用該屬性所指定的目錄來裝載或儲存檔案。
                shortcut.WorkingDirectory = System.Environment.CurrentDirectory;
                shortcut.WindowStyle = 1; //目標應用程式的視窗狀態分為普通、最大化、最小化【1,3,7】
                shortcut.Description = FileName; //描述
                shortcut.IconLocation = System.Windows.Forms.Application.ExecutablePath;  //快捷方式圖示
                shortcut.Arguments = "";
                //shortcut.Hotkey = "CTRL+ALT+F11"; // 快捷鍵
                shortcut.Save(); //必須呼叫儲存快捷才成建立成功
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(resources.FailMsg3);
                return;
            }
        }
        public static void DeleteDesktopShortcut()
        {
            if (System.IO.File.Exists(deskTop + FileName + ".lnk"))  //
            {
                System.IO.File.Delete(deskTop + FileName + ".lnk");
            }
        }
    }
}
