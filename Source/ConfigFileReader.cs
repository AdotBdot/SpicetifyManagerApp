using System;
using System.Collections.Generic;
using System.Linq;

namespace SpicetifyManager
{
    public class ConfigFileReader : ConfigFileLoader
    {
        public ConfigFileReader(string configFile = "")
        {
            ConfigFilePath = configFile;
        }

        public string ReadString(string name)
        {
            foreach(string Line in Lines)
            {
                if(Line.Contains(name))
                {
                    string L = RemoveWhitespace(Line);
                    return L.Substring(L.IndexOf("=", StringComparison.Ordinal) + 1);
                }
            }

            return string.Empty;
        }

        public string ReadFullString(string name)
        {
            foreach(string Line in Lines)
            {
                if(Line.Contains(name))
                {
                    return Line.Substring(Line.IndexOf("= ", StringComparison.Ordinal) + 1).Trim();
                }
            }

            return string.Empty;
        }

        public bool ReadBool(string name)
        {
            foreach(string Line in Lines)
            {
                if(Line.Contains(name))
                {
                    string L = RemoveWhitespace(Line);
                    return L.Substring(L.IndexOf("=", StringComparison.Ordinal) + 1) == "1" ? true : false;
                }
            }

            return false;
        }

        public List<string> ReadList(string name)
        {
            foreach(string Line in Lines)
            {
                if(Line.Contains(name))
                {
                    string L = RemoveWhitespace(Line);
                    L = L.Substring(L.IndexOf("=", StringComparison.Ordinal) + 1);
                    List<string> ReturnValue = new List<string>();

                    while(L.Contains("|"))
                    {
                        string Value = L.Substring(0, L.IndexOf("|", StringComparison.Ordinal));
                        ReturnValue.Add(Value);
                        L = L.Replace(Value + "|", string.Empty);
                    }

                    ReturnValue.Add(L);

                    return ReturnValue;
                }
            }

            return new List<string>();
        }

        private string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());
        }
    }
}