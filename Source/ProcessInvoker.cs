using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SpicetifyManager.Source
{
    internal static class ProcessInvoker
    {
        public static List<string> Invoke(string fileName, string args)
        {
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = fileName, //"C:\\Windows\\System32\\fsutil.exe",
                    Arguments = args, //"behavior query SymlinkEvaluation",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                },
            };

            process.Start();

            List<string> result = new List<string>();
            while(!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                result.Add(line);
            }

            process.WaitForExit();
            return result;
        }
        public static void PrintInvoke(List<string> results)
        {
            foreach (string line in results)
            {
                Console.WriteLine(ClearEscapeSeq(line));
            }
        }
        private static string ClearEscapeSeq(string text)
        {
            while (text.Contains("\u001b"))
            {
                text = text.Remove(text.IndexOf("\u001b"), text.IndexOf('m', text.IndexOf("\u001b")) - text.IndexOf("\u001b") + 1);
            }

            return text;
        }
    }
}