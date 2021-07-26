using System.IO;

namespace SpicetifyManager
{
    public class ConfigFileLoader
    {
        public ConfigFileLoader(string configFile = "")
        {
            ConfigFilePath = configFile;
        }

        //TODO: Implementation
        public void AutoDetectConfigFile()
        {
        }

        public void LoadFile()
        {
            Lines = File.ReadAllLines(ConfigFilePath);
        }

        protected string ConfigFilePath;
        protected string[] Lines;
    }
}