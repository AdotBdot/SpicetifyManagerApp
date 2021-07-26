﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;

namespace SpicetifyManager
{
    namespace My
    {
        public static class Fonts
        {
            public static PrivateFontCollection PFC = new PrivateFontCollection();
        }

        public static class Colors
        {
            public static Color GetBg(int elevationStep)
            {
                switch(elevationStep)
                {
                case 0:
                    return Color.FromArgb(18, 18, 18);
                case 1:
                    return Color.FromArgb(29, 29, 29);
                case 2:
                    return Color.FromArgb(33, 33, 33);
                case 3:
                    return Color.FromArgb(36, 36, 36);
                case 4:
                    return Color.FromArgb(38, 38, 38);
                case 5:
                    return Color.FromArgb(44, 44, 44);
                case 6:
                    return Color.FromArgb(45, 45, 45);
                case 7:
                    return Color.FromArgb(50, 50, 50);
                case 8:
                    return Color.FromArgb(53, 53, 53);
                case 9:
                    return Color.FromArgb(55, 55, 55);
                default:
                    return Color.FromArgb(18, 18, 18);
                }
            }

            public static Color Primary = Color.FromArgb(234, 82, 58);
            public static Color TxtLight = SystemColors.ControlLightLight;
            public static Color TxtDark = SystemColors.ControlText;
        }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            My.Fonts.PFC.AddFontFile(@"..\..\OpenSans-Regular.ttf");
            My.Fonts.PFC.AddFontFile(@"..\..\OpenSans-SemiBold.ttf");
            My.Fonts.PFC.AddFontFile(@"..\..\OpenSans-Bold.ttf");

            string UserDirectory = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\.spicetify\");
            string CliDirectory = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\spicetify-cli\");

            Spicetify Spicetify = new Spicetify(UserDirectory, CliDirectory);
            Settings Settings = new Settings(Spicetify.GetConfigPath());

            Settings.LoadConfig();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(Settings, Spicetify));
        }
    }
}