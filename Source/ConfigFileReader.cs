using System;
using System.Collections.Generic;
using System.Linq;

namespace SpicetifyManager
{
    public class ConfigFileReader : ConfigFileLoader
    {
        public ConfigFileReader()
        {
        }

        public string ReadString(string section, string key)
        {
            /*foreach(string Line in Lines)
            {
                if(Line.Contains(name))
                {
                    string L = RemoveWhitespace(Line);
                    return L.Substring(L.IndexOf("=", StringComparison.Ordinal) + 1);
                }
            }

            return string.Empty;*/
            if(!Data[section].ContainsKey(key))
                return String.Empty;
            return Data[section][key];
        }

        public bool ReadBool(string section, string key)
        {
            if(!Data[section].ContainsKey(key))
                return false;

            return ReadString(section, key) == "1" ? true : false;
            /*foreach(string Line in Lines)
            {
                if(Line.Contains(name))
                {
                    string L = RemoveWhitespace(Line);
                    return L.Substring(L.IndexOf("=", StringComparison.Ordinal) + 1) == "1" ? true : false;
                }
            }

            return false;*/
        }

        public List<string> ReadList(string section, string key)
        {
            if(!Data[section].ContainsKey(key))
                return new List<string>();

            string L = RemoveWhitespace(ReadString(section, key));
            List<string> ReturnValue = new List<string>();
            while(L.Contains("|"))
            {
                string Value = L.Substring(0, L.IndexOf("|", StringComparison.Ordinal));
                ReturnValue.Add(Value);
                L = L.Replace(Value + "|", string.Empty);
            }

            ReturnValue.Add(L);

            return ReturnValue;

            /*foreach(string Line in Lines)
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
            */
            return new List<string>();
        }

        private string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());
        }
    }
}