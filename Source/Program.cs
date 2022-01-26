using System;
using System.Runtime.InteropServices;
using Application = System.Windows.Forms.Application;

namespace SpicetifySettingsApp.Source
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        public static void ToogleConsole()
        {
            if(IsWindowVisible(GetConsoleWindow()))
                ShowWindow(GetConsoleWindow(), SW_HIDE);
            else
                ShowWindow(GetConsoleWindow(), SW_SHOW);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ShowWindow(GetConsoleWindow(), SW_HIDE);

            Fonts.LoadFonts();
            StaticData.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}