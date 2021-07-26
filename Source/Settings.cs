using System;
using System.Collections.Generic;
using System.Linq;

namespace SpicetifyManager
{
    public class Settings
    {
        public Settings(string configFilePath)
        {
            _Reader = new ConfigFileReader(configFilePath);
            _Writer = new ConfigFileWriter(configFilePath);
        }

        public void LoadConfig()
        {
            _Reader.LoadFile();

            ReadSetting();
            ReadPreprocesses();
            ReadAdditionalOptions();
            ReadBackup();
        }

        public void SaveThemes()
        {
            _Writer.LoadFile();
            _Writer.WriteString("current_theme", CurrentTheme);
            _Writer.WriteString("color_scheme", ColorScheme);
            _Writer.WriteFile();
        }

        public void SavePlugins()
        {
            _Writer.LoadFile();
            _Writer.WriteList("extensions", ExtensionsList);
            _Writer.WriteList("custom_apps", CustomAppsList);
            _Writer.WriteFile();
        }

        public void SaveSettings()
        {
            _Writer.LoadFile();
            _Writer.WriteString("prefs_path", PrefsPath);
            _Writer.WriteBool("overwrite_assets", OverwriteAssets);
            _Writer.WriteBool("check_spicetify_upgrade", CheckSpicetifyUpgrade);
            _Writer.WriteString("spotify_path", SpotifyPath);
            _Writer.WriteString("current_theme", CurrentTheme);
            _Writer.WriteString("color_scheme", ColorScheme);
            _Writer.WriteBool("inject_css", InjectCss);
            _Writer.WriteBool("replace_colors", ReplaceColors);
            _Writer.WriteString("spotify_launch_flags", SpotifyLaunchFlags);

            _Writer.WriteBool("disable_sentry", DisableSentry);
            _Writer.WriteBool("disable_ui_logging", DisableUiLogging);
            _Writer.WriteBool("remove_rtl_rule", RemoveRtlRule);
            _Writer.WriteBool("expose_apis", ExposeApis);
            _Writer.WriteBool("disable_upgrade_check", DisableUpgradeCheck);

            _Writer.WriteBool("home_config", HomeConfig);
            _Writer.WriteBool("sidebar_config", SidebarConfig);
            _Writer.WriteFile();
        }

        private void ReadSetting()
        {
            PrefsPath = _Reader.ReadString("prefs_path");
            OverwriteAssets = _Reader.ReadBool("overwrite_assets");
            CheckSpicetifyUpgrade = _Reader.ReadBool("check_spicetify_upgrade");
            SpotifyPath = _Reader.ReadString("spotify_path");
            CurrentTheme = _Reader.ReadString("current_theme");
            ColorScheme = _Reader.ReadString("color_scheme");
            InjectCss = _Reader.ReadBool("inject_css");
            ReplaceColors = _Reader.ReadBool("replace_colors");
            SpotifyLaunchFlags = _Reader.ReadFullString("spotify_launch_flags");
        }

        private void ReadPreprocesses()
        {
            DisableSentry = _Reader.ReadBool("disable_sentry");
            DisableUiLogging = _Reader.ReadBool("disable_ui_logging");
            RemoveRtlRule = _Reader.ReadBool("remove_rtl_rule");
            ExposeApis = _Reader.ReadBool("expose_apis");
            DisableUpgradeCheck = _Reader.ReadBool("disable_upgrade_check");
        }

        private void ReadAdditionalOptions()
        {
            HomeConfig = _Reader.ReadBool("home_config");
            ExtensionsList = _Reader.ReadList("extensions");
            CustomAppsList = _Reader.ReadList("custom_apps");
            SidebarConfig = _Reader.ReadBool("sidebar_config");
        }

        private void ReadBackup()
        {
            SpotifyVersion = _Reader.ReadString("version");
        }

        private ConfigFileReader _Reader;
        private ConfigFileWriter _Writer;

        //Settings
        public string PrefsPath;
        public bool OverwriteAssets;
        public bool CheckSpicetifyUpgrade;
        public string SpotifyPath;
        public string CurrentTheme;
        public string ColorScheme;
        public bool InjectCss;
        public bool ReplaceColors;
        public string SpotifyLaunchFlags;

        //Preprocesses
        public bool DisableSentry;
        public bool DisableUiLogging;
        public bool RemoveRtlRule;
        public bool ExposeApis;
        public bool DisableUpgradeCheck;

        //AdditionalOptions
        public bool HomeConfig;
        public List<string> ExtensionsList;
        public List<string> CustomAppsList;
        public bool SidebarConfig;

        //Backup
        public string SpotifyVersion;
    }
}