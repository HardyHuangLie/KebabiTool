using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Memory;
using swf = System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;
using Newtonsoft.Json;
using System.Windows.Markup;
using System.Security.Principal;

namespace Kebabi
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReadJson();
            Watch_Window();
            CreatShortCut.IsChecked = ShortCut.IsDesktopShortcut();
            isAdmin();
        }
        int Remove_all = 10;
        bool is_Run= false;
        private void Remove_Checked(object sender, RoutedEventArgs e)
        {
            Remove_all = 10;
            Zero.IsChecked = false;
            First.IsChecked = false;
            Second.IsChecked = false;
            Third.IsChecked = false;
            Forth.IsChecked = false;
            Sixth.IsChecked = false;
            Fifth.IsChecked = false;
            Change();
            Save();
        }

        private async void Start_Click(object sender, RoutedEventArgs e)
        {
           try
           {
                if(Start.Content.ToString()==resources.Start)
                {
                    swf.Application.DoEvents();
                    Process.Start("injector.exe");
                    swf.Application.DoEvents();
                    Get_Window();
                    swf.Application.DoEvents();
                    await Task.Run(() =>
                    {
                        Thread.Sleep(GetDelay());
                    });
                    swf.Application.DoEvents();
                    Change();
                }
                else
                {
                    Window_Close();
                }
           }
            catch(Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }

        private void First_Checked(object sender, RoutedEventArgs e)
        {
            Remove_all = 1;
            Remove.IsChecked = false;
            Zero.IsChecked = false;
            Second.IsChecked = false;
            Third.IsChecked = false;
            Forth.IsChecked = false;
            Sixth.IsChecked = false;
            Fifth.IsChecked = false;
            Change();
            Save();
        }

        private void Forth_Checked(object sender, RoutedEventArgs e)
        {
            Remove_all = 4;
            Remove.IsChecked = false;
            Zero.IsChecked = false;
            First.IsChecked = false;
            Second.IsChecked = false;
            Third.IsChecked = false;
            Sixth.IsChecked = false;
            Fifth.IsChecked = false;
            Change();
            Save();
        }

        private void Third_Checked(object sender, RoutedEventArgs e)
        {
            Remove_all = 3;
            Remove.IsChecked = false;
            Zero.IsChecked = false;
            First.IsChecked = false;
            Second.IsChecked = false;
            Forth.IsChecked = false;
            Sixth.IsChecked = false;
            Fifth.IsChecked = false;
            Change();
            Save();
        }

        private void Second_Checked(object sender, RoutedEventArgs e)
        {
            Remove_all = 2;
            Remove.IsChecked = false;
            Zero.IsChecked = false;
            First.IsChecked = false;
            Third.IsChecked = false;
            Forth.IsChecked = false;
            Sixth.IsChecked = false;
            Fifth.IsChecked = false;
            Change();
            Save();
        }

        private void Fifth_Checked(object sender, RoutedEventArgs e)
        {
            Remove_all = 5;
            Remove.IsChecked = false;
            Zero.IsChecked = false;
            First.IsChecked = false;
            Second.IsChecked = false;
            Third.IsChecked = false;
            Forth.IsChecked = false;
            Sixth.IsChecked = false;
            Change();
            Save();
        }

        private void Sixth_Checked(object sender, RoutedEventArgs e)
        {
            Remove_all = 6;
            Remove.IsChecked = false;
            Zero.IsChecked = false;
            First.IsChecked = false;
            Second.IsChecked = false;
            Third.IsChecked = false;
            Forth.IsChecked = false;
            Fifth.IsChecked = false;
            Change();
            Save();
        }

        private void Zero_Checked(object sender, RoutedEventArgs e)
        {
            Remove_all = 0;
            Remove.IsChecked = false;
            First.IsChecked = false;
            Second.IsChecked = false;
            Third.IsChecked = false;
            Forth.IsChecked = false;
            Sixth.IsChecked = false;
            Fifth.IsChecked = false;
            Change();
            Save();
        }
        void Change()
        {
            if (is_Run)
            {
                if (Remove_all == 0)
                {
                    Mem mem = new Mem();
                    if (!mem.OpenProcess("GenshinImpact"))
                    {
                        MessageBox.Show(resources.FailMsg1);
                    }
                    else if(!mem.WriteMemory("mhyprot.dll+377050", "int", "0")&&! mem.WriteMemory("mhyprot.dll+377064", "int", Remove_all.ToString()) && @mem.WriteMemory("mhyprot.dll+377057", "bytes", "90 90 90 90 90 90 90"))
                    {
                        MessageBox.Show(resources.FailMsg2);
                    }
                    mem.CloseProcess();
                    is_Run = true;
                }
                else
                {
                    Mem mem = new Mem();
                    if (!mem.OpenProcess("GenshinImpact"))
                    {
                        MessageBox.Show(resources.FailMsg1);
                    }
                    else if (!mem.WriteMemory("mhyprot.dll+377050", "int", "1") || !mem.WriteMemory("mhyprot.dll+377064", "int", Remove_all.ToString()) || !mem.WriteMemory("mhyprot.dll+377057", "bytes", "90 90 90 90 90 90 90"))
                    {
                        MessageBox.Show(resources.FailMsg2);
                    }
                    mem.CloseProcess();
                    is_Run = true;
                }
            }
        }
        void Watch_Window()
        {
            Task.Run(() => {
                for(; ; )
                {
                    Get_Window();
                    this.Dispatcher.Invoke((Action)(() =>
                    {
                        Start.Content = resources.Close;
                        is_Run = true;
                    }));
                    Get_Window_Close();
                    this.Dispatcher.Invoke((Action)(() =>
                    {
                        Start.Content = resources.Start;
                        is_Run = false;
                    }));
                }
            });
        }
        void Window_Close()
        {
            string processName = "GenshinImpact";
            // 查找符合條件的進程
            Process[] processes = Process.GetProcessesByName(processName);
            swf.Application.DoEvents();
            processes[0].Kill();
        }
        void Get_Window_Close()
        {
            for (; ; )
            {
                string processName = "GenshinImpact";

                // 查找符合條件的進程
                Process[] processes = Process.GetProcessesByName(processName);
                swf.Application.DoEvents();

                if (processes.Length <= 0)
                {
                    return;
                }
                Thread.Sleep(100);
                swf.Application.DoEvents();
            }
        }
        void Get_Window()
        {
            swf.Application.DoEvents();
            for (; ; )
            {
                string processName = "GenshinImpact";

                // 查找符合條件的進程
                Process[] processes = Process.GetProcessesByName(processName);
                swf.Application.DoEvents();

                if (processes.Length > 0)
                {
                    return;
                }
                swf.Application.DoEvents();
                Thread.Sleep(100);
                swf.Application.DoEvents();
            }
        }

        private void CreatShortCut_Checked(object sender, RoutedEventArgs e)
        {
            ShortCut.CreateDesktopShortcut();
        }

        private void CreatShortCut_Unchecked(object sender, RoutedEventArgs e)
        {
            ShortCut.DeleteDesktopShortcut();
        }
        string Path = "save.ini";
        class Data
        {
            public int id { get; set; }
        }
        public void ReadJson()
        {
            Data data = new Data();
            Create_ini();
            string read = File.ReadAllText(Path);
            data = JsonConvert.DeserializeObject<Data>(read);
            switch (data.id)
            {
                case 0: Zero.IsChecked= true; break;
                case 1: First.IsChecked = true; break;
                case 2: Second.IsChecked = true; break;
                case 3: Third.IsChecked = true; break;
                case 4: Forth.IsChecked = true; break;
                case 5: Fifth.IsChecked = true; break;
                case 6: Sixth.IsChecked = true; break;
                case 10: Remove.IsChecked = true; break;
            }
        }
        public void Create_ini()
        {
            if (!File.Exists(Path))
            {
                FileStream fs1 = new FileStream(Path, FileMode.Create);
                fs1.Close();
                Save();
            }
        }
        int GetDelay()
        {
            string filePath = "cfg.ini";
            string line = null;

            using (StreamReader reader = new StreamReader(filePath))
            {
                int delayMS = 15000;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("InitializationDelayMS"))
                    {
                        string[] parts = line.Split('=');
                        delayMS = int.Parse(parts[1].Trim());
                        return delayMS;
                    }
                }
                return delayMS;
            }
        }
        public  void Save()
        {
            if (!File.Exists(Path))
            {
                FileStream fs1 = new FileStream(Path, FileMode.Create);
                fs1.Close();
            }
            var Json = new Data
            {
                id = Remove_all
            };
            string jsonString = JsonConvert.SerializeObject(Json);
            File.WriteAllText(Path, jsonString);
        }
        void isAdmin()
        {
            bool isAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

            // 如果未以系統管理員身分執行，則重新以系統管理員身分啟動應用程式
            if (!isAdmin)
            {
                // 重新啟動應用程式，並指定以系統管理員身分執行
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = true;
                startInfo.WorkingDirectory = Environment.CurrentDirectory;
                startInfo.FileName = System.Reflection.Assembly.GetEntryAssembly().Location;
                startInfo.Verb = "runas"; // 指定以系統管理員身分執行
                try
                {
                    Process.Start(startInfo);
                }
                catch
                {
                    // 無法以系統管理員身分啟動
                    // 可以在這裡進行錯誤處理
                    return;
                }

                // 退出當前應用程式
                Application.Current.Shutdown();
            }
        }
    }
}
