using SpicetifyManager.Source;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace SpicetifyManager
{
    public class Spicetify
    {
        public Spicetify(string userDirectory, string cliDirectory)
        {
            _UserDirectory = userDirectory;
            _CliDirectory = cliDirectory;

            Detected = DetectSpicetify();
            Version = ReadVersion();
        }

        public void ListAll()
        {
            ListThemes();
            ListExtensions();
            ListCustomApps();
        }

        public List<string> GetColors(string themeName)
        {
            if(!Detected)
                return new List<string>();

            string[] lines;

            try
            {
                lines = File.ReadAllLines(_UserDirectory + "Themes\\" + themeName + "\\color.ini");
            }
            catch(FileNotFoundException)
            {
                return new List<string>();
            }
            catch(DirectoryNotFoundException e)
            {
                try
                {
                    lines = File.ReadAllLines(_UserDirectory + "..\\spicetify-cli\\Themes\\" + themeName + "\\color.ini");
                }
                catch(FileNotFoundException)
                {
                    return new List<string>();
                }
                catch(DirectoryNotFoundException)
                {
                    return new List<string>();
                }
                catch(Exception exception)
                {
                    Console.WriteLine("Handled: " + e);
                    Console.WriteLine("Unhandled exception:" + exception);
                    return new List<string>();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Unhandled exception:" + e);
                return new List<string>();
            }

            List<string> returnValue = new List<string>();

            foreach(string line in lines)
            {
                if(line.StartsWith("["))
                {
                    string color = line;
                    color = color.Replace("[", "").Replace("]", "");
                    returnValue.Add(color);
                }
            }

            return returnValue;
        }
        public List<string> GetThemes()
        {
            return _Themes;
        }
        public List<string> GetExtensions()
        {
            return _Extensions;
        }
        public List<string> GetCustomApps()
        {
            return _CustomApps;
        }

        public string GetConfigPath()
        {
            if (!Detected)
                return string.Empty;

            List<string> results = ProcessInvoker.Invoke(_CliDirectory + "spicetify.exe", "-c");

            return results[0];
        }

        public void OpenThemeFolder()
        {
            if(!Detected)
                return;

            Process.Start(new ProcessStartInfo()
            {
                FileName = _UserDirectory + "Themes\\",
                UseShellExecute = true,
                Verb = "open"
            });
        }

        public void OpenExtensionsFolder()
        {
            if(!Detected)
                return;

            Process.Start(new ProcessStartInfo()
            {
                FileName = _UserDirectory + "Extensions\\",
                UseShellExecute = true,
                Verb = "open"
            });
        }

        public void OpenCustomAppsFolder()
        {
            if(!Detected)
                return;

            Process.Start(new ProcessStartInfo()
            {
                FileName = _UserDirectory + "CustomApps\\",
                UseShellExecute = true,
                Verb = "open"
            });
        }

        public void OpenConfigFile()
        {
            if(!Detected)
                return;

            Process.Start(new ProcessStartInfo()
            {
                FileName = GetConfigPath(),
                UseShellExecute = true,
            });
        }


        public async Task Apply()
        {
            if(!Detected)
                return;

            Console.WriteLine("Applying...");
            var results = ProcessInvoker.Invoke(_CliDirectory + "spicetify.exe", "apply");

            ProcessInvoker.PrintInvoke(results);
        }

        public async Task Backup()
        {
            if (!Detected)
                return;

            Console.WriteLine("Backuping...");
            var response = ProcessInvoker.Invoke(_CliDirectory + "spicetify.exe", "backup");

            ProcessInvoker.PrintInvoke(response);
        }

        public async Task Clear()
        {
            if (!Detected)
                return;

            Console.WriteLine("Clearing Backup...");
            var response = ProcessInvoker.Invoke(_CliDirectory + "spicetify.exe", "-q clear");

            ProcessInvoker.PrintInvoke(response);
        }

        public async Task Update()
        {
            if (!Detected)
                return;

            Console.WriteLine("Updating...");
            var response = ProcessInvoker.Invoke(_CliDirectory + "spicetify.exe", "update");

            ProcessInvoker.PrintInvoke(response);
        }

        public async Task Restore()
        {
            if (!Detected)
                return;


            Console.WriteLine("Restoring Spotify...");
            var response = ProcessInvoker.Invoke(_CliDirectory + "spicetify.exe", "restore");

            ProcessInvoker.PrintInvoke(response);
        }

        public async Task Upgrade()
        {
            if (!Detected)
                return;

            Console.WriteLine("Upgrading Spicetify...");
            var response = ProcessInvoker.Invoke(_CliDirectory + "spicetify.exe", "upgrade");

            ProcessInvoker.PrintInvoke(response);
        }

        public async Task Restart()
        {
            if (!Detected)
                return;

            Console.WriteLine("Restarting Spotify...");
            var response = ProcessInvoker.Invoke(_CliDirectory + "spicetify.exe", "restart");

            ProcessInvoker.PrintInvoke(response);
        }

        private bool DetectSpicetify()
        {
            try
            {
                return File.Exists(_CliDirectory + "spicetify.exe");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        private string ReadVersion()
        {
            if (!Detected)
                return "Not detected";

            var results = ProcessInvoker.Invoke(_CliDirectory + "spicetify.exe", "-v");
            return results[0];
        }

        private void ListThemes()
        {
            if(!Detected)
            {
                _Themes = new List<string>();
                return;
            }

            _Themes = new List<string> { "(none)" };

            //.spicetify
            string[] userThemes = Directory.GetDirectories(_UserDirectory + "Themes");
            foreach(string theme in userThemes)
            {
                _Themes.Add(theme.Substring(theme.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }

            //spicetify-cli
            string[] buildInThemes = Directory.GetDirectories(_CliDirectory + "Themes");
            foreach(string theme in buildInThemes)
            {
                _Themes.Add(theme.Substring(theme.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }
        }

        private void ListExtensions()
        {
            if(!Detected)
            {
                _Extensions = new List<string>();
                return;
            }

            _Extensions = new List<string>();

            //.spicetify
            string[] userExt = Directory.GetFiles(_UserDirectory + "Extensions");
            foreach(string ext in userExt)
            {
                _Extensions.Add(ext.Substring(ext.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }

            //spicetify-cli
            string[] buildInExt = Directory.GetFiles(_CliDirectory + "Extensions");
            foreach(string ext in buildInExt)
            {
                _Extensions.Add(ext.Substring(ext.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }
        }

        private void ListCustomApps()
        {
            if(!Detected)
            {
                _CustomApps = new List<string>();
                return;
            }

            _CustomApps = new List<string>();

            //.spicetify
            string[] userApps = Directory.GetDirectories(_UserDirectory + "CustomApps");
            foreach(string app in userApps)
            {
                _CustomApps.Add(app.Substring(app.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }

            //spicetify-cli
            string[] buildInApps = Directory.GetDirectories(_CliDirectory + "\\CustomApps");
            foreach(string app in buildInApps)
            {
                _CustomApps.Add(app.Substring(app.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }
        }

        public string Version;
        public readonly bool Detected;

        private List<string> _Extensions;
        private List<string> _CustomApps;
        private List<string> _Themes;

        private readonly string _UserDirectory;
        private readonly string _CliDirectory;
    }
}