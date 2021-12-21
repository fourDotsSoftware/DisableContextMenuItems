using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Diagnostics;

namespace DisableContextMenuItems
{
    class RegistryHelper
    {
        public static string GetRegistryKeyValue(string regpath,string key, bool lm)
        {
            RegistryKey reg = lm ? Registry.LocalMachine : Registry.CurrentUser;

            try
            {
                RegistryKey regkey=reg.OpenSubKey(regpath,false);

                if (regkey != null)
                {
                    try
                    {
                        return regkey.GetValue(key).ToString();
                    }
                    catch
                    {
                        return null;
                    }
                    finally
                    {
                        regkey.Close();                        
                    }
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        public static string GetAppRegistryKeyValue(string key, bool lm)
        {
            return GetAppRegistryKeyValue(Module.ApplicationName, key, lm);
        }

        public static string GetAppRegistryKeyValue(string app, string key, bool lm)
        {
            RegistryKey reg = lm ? Registry.LocalMachine : Registry.CurrentUser;

            try
            {
                RegistryKey regkey = reg.OpenSubKey(@"Software\4dots Software\"+app, false);

                if (regkey != null)
                {
                    try
                    {
                        return regkey.GetValue(key).ToString();
                    }
                    catch
                    {
                        return null;
                    }
                    finally
                    {
                        regkey.Close();
                    }
                }
            }
            catch
            {
                return null;
            }

            return null;
        }

        public static bool SetAppRegistryKeyValue(string key, string keyvalue, bool lm)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            if (lm)
            {
                p.StartInfo.Arguments = " -regkeylm \"" + Module.ApplicationName + "\" \"" + key + "\"" + " \"" + keyvalue + "\"";
            }
            else
            {
                p.StartInfo.Arguments = " -regkey \"" + Module.ApplicationName + "\" \"" + key + "\"" + " \"" + keyvalue + "\"";
            }

            p.StartInfo.FileName = "4dotsAdminActions.exe";

            p.StartInfo.WorkingDirectory = Application.StartupPath;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            p.Start();
            p.WaitForExit();

            //System.Diagnostics.Process.Start(System.IO.Path.Combine(Application.StartupPath, "DisableContextMenuItemsServiceManager.exe"), "");

            if (p.ExitCode != 0)
            {
                Module.ShowMessage("Error could not set Settings !");
                return false;
            }

            return true;
        }
    }
}
