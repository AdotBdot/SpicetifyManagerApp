using System.Collections.Generic;

namespace SpicetifyManager
{
    class ConfigFileWriter : ConfigFileLoader
    {
        public ConfigFileWriter()
        {
        }

        public void WriteString(string section, string key, string value)
        {
            Data[section][key] = value;
        }

        public void WriteBool(string section, string key, bool value)
        {
            Data[section][key] = (value == true ? "1" : "0");
        }

        public void WriteList(string section, string key, List<string> value)
        {
            string S;

            if(value.Count != 0)
            {
                S = value[0];
                for(int I = 1; I < value.Count; I++)
                {
                    S += "|";
                    S += value[I];
                }
            }
            else
            {
                S = string.Empty;
            }

            Data[section][key] = S;
        }

        public void WriteFile(string configFile)
        {
            Parser.WriteFile(configFile, Data);
        }
    }
}