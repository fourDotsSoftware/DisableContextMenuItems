using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace DisableContextMenuItems
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            

            ExceptionHandlersHelper.AddUnhandledExceptionHandlers();
            
            frmLanguage.SetLanguages();
            frmLanguage.SetLanguage();

            if (args.Length > 0 && args[0].StartsWith("/uninstall"))
            {
                Module.DeleteApplicationSettingsFile();

                /*
                frmUninstallQuestionnaire fq = new frmUninstallQuestionnaire();
                fq.ShowDialog();
                */

                System.Diagnostics.Process.Start("https://www.4dots-software.com/support/bugfeature.php?uninstall=true&app=" + System.Web.HttpUtility.UrlEncode(Module.ShortApplicationTitle));
                
                Environment.Exit(0);

                return;
            }

            ActivateIfApplicationIsRunning(Module.ApplicationName.Replace(" ", ""));
                        
            frmMain f=new frmMain();            

            Application.Run(f);
        }

        private static void ActivateIfApplicationIsRunning(string applicationName)
        {
            try
            {
                Process[] procs = System.Diagnostics.Process.GetProcessesByName(applicationName);

                int ialive = -1;
                for (int k = 0; k <= procs.GetUpperBound(0); k++)
                {
                    if (System.Diagnostics.Process.GetCurrentProcess().Id != procs[k].Id)
                    {
                        if (!procs[k].HasExited)
                        {
                            ialive = k;
                            break;
                        }
                    }
                }

                if (ialive != -1)
                {
                    MessageHelper msg = new MessageHelper();
                    int result = 0;
                    //First param can be null

                    IntPtr hWnd = procs[ialive].MainWindowHandle;

                    while (hWnd == IntPtr.Zero)
                    {
                        Application.DoEvents();

                        MessageHelper.PostMessage((IntPtr)MessageHelper.HWND_BROADCAST, (UInt32)MessageHelper.WM_ACTIVATEAPP, IntPtr.Zero, IntPtr.Zero);

                        procs = System.Diagnostics.Process.GetProcessesByName(applicationName);

                        ialive = -1;
                        for (int k = 0; k <= procs.GetUpperBound(0); k++)
                        {
                            if (System.Diagnostics.Process.GetCurrentProcess().Id != procs[k].Id)
                            {
                                if (!procs[k].HasExited)
                                {
                                    ialive = k;
                                    break;
                                }
                            }
                        }

                        if (ialive != -1)
                        {
                            hWnd = procs[ialive].MainWindowHandle;
                        }
                    }

                    msg.bringAppToFront(hWnd);

                    result = msg.sendWindowsStringMessage(hWnd, IntPtr.Zero, "SHOW");

                    Environment.Exit(0);
                    return;
                }
            }
            catch { }
        }
    }
}
