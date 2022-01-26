using System;
using SpicetifyManager;

namespace SpicetifySettingsApp.Source
{
    internal class StaticData
    {
        public static void Init()
        {
            UserDirectory = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\.spicetify\");
            CliDirectory = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\spicetify-cli\");

            Spicetify = new Spicetify(UserDirectory, CliDirectory);
            Settings = new Settings(Spicetify);

            Spicetify.ListAll();
            Settings.LoadConfig();
        }

        public static string UserDirectory;
        public static string CliDirectory;

        public static Spicetify Spicetify;
        public static Settings Settings;

        public const string Version = "v1.3.3";
    }
}