using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using System.Windows.Forms;

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

            ListAll();
        }

        public bool DetectSpicetify()
        {
            return File.Exists(_CliDirectory + "spicetify.exe");
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

            string[] Lines;
            List<string> ReturnValue = new List<string>();
            try
            {
                Lines = File.ReadAllLines(_UserDirectory + "Themes\\" + themeName + "\\color.ini");
            }
            catch(Exception E)
            {
                try
                {
                    Lines = File.ReadAllLines(
                        _UserDirectory + "..\\spicetify-cli\\Themes\\" + themeName + "\\color.ini");
                }
                catch(Exception Exception)
                {
                    Console.WriteLine(E);
                    Console.WriteLine(Exception);
                    return ReturnValue;
                }
            }

            foreach(string Line in Lines)
            {
                if(Line.StartsWith("["))
                {
                    string Color = Line;
                    Color = Color.Replace("[", "").Replace("]", "");
                    ReturnValue.Add(Color);
                }
            }

            return ReturnValue;
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


        public string GetConfigPath()
        {
            if(!Detected)
                return string.Empty;

            Collection<PSObject> Results = PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe")
                .AddParameter("-c").Invoke();

            return Results[0].ToString();
        }


        public void Apply()
        {
            if(!Detected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("apply").Invoke();
        }

        public void Backup()
        {
            if(!Detected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("backup").Invoke();
        }

        public void Clear()
        {
            if(!Detected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddParameter("-q").AddArgument("clear").Invoke();
        }

        public void Update()
        {
            if(!Detected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("update").Invoke();
        }

        public void Restore()
        {
            if(!Detected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("restore").Invoke();
        }

        public void Upgrade()
        {
            if(!Detected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("upgrade").Invoke();
        }

        public void Restart()
        {
            if(!Detected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("restart").Invoke();
        }


        public void Install()
        {
            if(Detected)
                return;

            //Invoke-WebRequest -UseBasicParsing "https://raw.githubusercontent.com/khanhas/spicetify-cli/master/install.ps1" | Invoke-Expression
            PowerShell.Create().AddCommand("Invoke-WebRequest").AddParameter("-UseBasicParsing")
                .AddArgument("https://raw.githubusercontent.com/khanhas/spicetify-cli/master/install.ps1")
                .AddCommand("Invoke-Expression").Invoke();

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").Invoke();
        }


        private string ReadVersion()
        {
            if(!Detected)
                return "Not detected";

            var Results = PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddParameter("-v").Invoke();

            return Results[0].ToString();
        }

        private void ListThemes()
        {
            if(!Detected)
            {
                _Themes = new List<string>();
                return;
            }

            _Themes = new List<string> {"(none)"};

            //.spicetify
            string[] UserThemes = Directory.GetDirectories(_UserDirectory + "Themes");
            foreach(string Theme in UserThemes)
            {
                _Themes.Add(Theme.Substring(Theme.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }

            //spicetify-cli
            string[] BuildInThemes = Directory.GetDirectories(_CliDirectory + "Themes");
            foreach(string Theme in BuildInThemes)
            {
                _Themes.Add(Theme.Substring(Theme.LastIndexOf("\\", StringComparison.Ordinal) + 1));
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
            string[] UserExt = Directory.GetFiles(_UserDirectory + "Extensions");
            foreach(string Ext in UserExt)
            {
                _Extensions.Add(Ext.Substring(Ext.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }

            //spicetify-cli
            string[] BuildInExt = Directory.GetFiles(_CliDirectory + "Extensions");
            foreach(string Ext in BuildInExt)
            {
                _Extensions.Add(Ext.Substring(Ext.LastIndexOf("\\", StringComparison.Ordinal) + 1));
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
            string[] UserApps = Directory.GetDirectories(_UserDirectory + "CustomApps");
            foreach(string App in UserApps)
            {
                _CustomApps.Add(App.Substring(App.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }

            //spicetify-cli
            string[] BuildInApps = Directory.GetDirectories(_CliDirectory + "\\CustomApps");
            foreach(string App in BuildInApps)
            {
                _CustomApps.Add(App.Substring(App.LastIndexOf("\\", StringComparison.Ordinal) + 1));
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