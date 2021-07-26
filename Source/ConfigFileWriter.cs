using System.Collections.Generic;
using System.IO;

namespace SpicetifyManager
{
    class ConfigFileWriter : ConfigFileLoader
    {
        public ConfigFileWriter(string configFile = "")
        {
            ConfigFilePath = configFile;
        }

        public void WriteString(string varName, string value)
        {
            for (int I = 0; I < Lines.Length; I++)
            {
                if (Lines[I].Contains(varName))
                {
                    Lines[I] = varName;
                    Lines[I] += " = ";
                    Lines[I] += value;
                }
            }
        }

        public void WriteBool(string varName, bool value)
        {
            for (int I = 0; I < Lines.Length; I++)
            {
                if (Lines[I].Contains(varName))
                {
                    Lines[I] = varName + " = " + (value == true ? "1" : "0");
                }
            }
        }

        public void WriteList(string varName, List<string> value)
        {
            for (int I = 0; I < Lines.Length; I++)
            {
                if (Lines[I].Contains(varName))
                {
                    if (value.Count != 0)
                    {
                        Lines[I] = varName + " = " + value[0];
                        for (int J = 1; J < value.Count; J++)
                        {
                            Lines[I] += "|";
                            Lines[I] += value[J];
                        }
                    }
                    else
                    {
                        Lines[I] = varName + " = ";
                    }
                }
            }
        }

        public void WriteFile()
        {
            File.WriteAllLines(ConfigFilePath, Lines);
        }
    }
}