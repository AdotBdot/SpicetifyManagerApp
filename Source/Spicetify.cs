﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;

namespace SpicetifyManager
{
    public class Spicetify
    {
        public Spicetify(string userDirectory, string cliDirectory)
        {
            _UserDirectory = userDirectory;
            _CliDirectory = cliDirectory;
            _SpicetifyDetected = DetectSpicetify();
            Version = ReadVersion();
            ListAll();
        }

        public bool DetectSpicetify()
        {
            return File.Exists(_CliDirectory + "spicetify.exe");
        }

        public void ListAll()
        {
            if(!_SpicetifyDetected)
                return;
            ListThemes();
            ListExtensions();
            ListCustomApps();
        }


        public List<string> GetColors(string themeName)
        {
            if(!_SpicetifyDetected)
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
            if(!_SpicetifyDetected)
                return new List<string>();
            return _ThemeList;
        }

        public List<string> GetExtensions()
        {
            if(!_SpicetifyDetected)
                return new List<string>();
            return _Extensions;
        }

        public List<string> GetCustomApps()
        {
            if(!_SpicetifyDetected)
                return new List<string>();
            return _CustomApps;
        }


        public void OpenThemeFolder()
        {
            if(!_SpicetifyDetected)
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
            if(!_SpicetifyDetected)
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
            if(!_SpicetifyDetected)
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
            if(!_SpicetifyDetected)
                return;

            Process.Start(new ProcessStartInfo()
            {
                FileName = _UserDirectory + "config-xpui.ini",
                UseShellExecute = true,
            });
        }


        public string GetConfigPath()
        {
            if(!_SpicetifyDetected)
                return String.Empty;

            var Results = PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddParameter("-c").Invoke();

            return Results[0].ToString();
        }


        public void Apply()
        {
            if(!_SpicetifyDetected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("apply").Invoke();
        }

        public void Backup()
        {
            if(!_SpicetifyDetected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("backup").Invoke();
        }

        public void Clear()
        {
            if(!_SpicetifyDetected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("clear").Invoke();
        }

        public void Update()
        {
            if(!_SpicetifyDetected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("update").Invoke();
        }

        public void Restore()
        {
            if(!_SpicetifyDetected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("restore").Invoke();
        }

        public void Upgrade()
        {
            if(!_SpicetifyDetected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("upgrade").Invoke();
        }

        public void Restart()
        {
            if(!_SpicetifyDetected)
                return;

            PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddArgument("restart").Invoke();
        }


        public void Install()
        {
            if(_SpicetifyDetected)
                return;

            //Invoke-WebRequest -UseBasicParsing "https://raw.githubusercontent.com/khanhas/spicetify-cli/master/install.ps1" | Invoke-Expression
            PowerShell.Create().AddCommand("Invoke-WebRequest").AddParameter("-UseBasicParsing")
                .AddArgument("https://raw.githubusercontent.com/khanhas/spicetify-cli/master/install.ps1")
                .AddCommand("Invoke-Expression").Invoke();
        }


        private string ReadVersion()
        {
            if(!_SpicetifyDetected)
                return "0.0.0";

            var Results = PowerShell.Create().AddCommand(_CliDirectory + "spicetify.exe").AddParameter("-v").Invoke();

            return Results[0].ToString();
        }

        private void ListThemes()
        {
            if(!_SpicetifyDetected)
                return;

            _ThemeList = new List<string> {"(none)"};

            //.spicetify
            string[] UserThemes = Directory.GetDirectories(_UserDirectory + "Themes");
            foreach(string Theme in UserThemes)
            {
                _ThemeList.Add(Theme.Substring(Theme.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }

            //spicetify-cli
            string[] BuildInThemes = Directory.GetDirectories(_CliDirectory + "Themes");
            foreach(string Theme in BuildInThemes)
            {
                _ThemeList.Add(Theme.Substring(Theme.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }
        }

        private void ListExtensions()
        {
            if(!_SpicetifyDetected)
                return;

            _Extensions = new List<string>();

            //.spicetify
            string[] UserExt = Directory.GetFiles(_UserDirectory + "Extensions");
            foreach(string Ext in UserExt)
            {
                _Extensions.Add(Ext.Substring(Ext.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }

            //spicetify-cli
            string[] BuildInExt = Directory.GetFiles(_UserDirectory + "..\\spicetify-cli\\Extensions");
            foreach(string Ext in BuildInExt)
            {
                _Extensions.Add(Ext.Substring(Ext.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }
        }

        private void ListCustomApps()
        {
            if(!_SpicetifyDetected)
                return;

            _CustomApps = new List<string>();

            //.spicetify
            string[] UserApps = Directory.GetDirectories(_UserDirectory + "CustomApps");
            foreach(string App in UserApps)
            {
                _CustomApps.Add(App.Substring(App.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }

            //spicetify-cli
            string[] BuildInApps = Directory.GetDirectories(_UserDirectory + "..\\spicetify-cli\\CustomApps");
            foreach(string App in BuildInApps)
            {
                _CustomApps.Add(App.Substring(App.LastIndexOf("\\", StringComparison.Ordinal) + 1));
            }
        }


        public string Version;

        private bool _SpicetifyDetected;

        private List<string> _Extensions;
        private List<string> _CustomApps;
        private List<string> _ThemeList;

        private readonly string _UserDirectory;
        private readonly string _CliDirectory;
    }
}