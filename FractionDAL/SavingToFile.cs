using System;
using System.IO;

namespace FractionDAL
{
    public class SavingToFile
    {
        public static string GetArithLogPath(){return Path.GetFullPath("ArithLog.csv");}
        public static string GetCompLogPath() {return Path.GetFullPath("CompaLog.csv");}
        public static void SaveToArithLog(Tuple<string, string, string, string> tuple)
        {
            SavingInFile(GetArithLogPath(), GetContent(tuple));
        }
        public static void SaveToCompaLog(Tuple<string, string, string, string> tuple)
        {
            SavingInFile(GetCompLogPath(), GetContent(tuple));
        }
        private static string GetContent(Tuple<string, string, string, string> tuple)
        {
            string content = "\n" + DateTime.Now.ToString("dd MMMM yyyy") + "," + DateTime.Now.ToString("HH:mm:ss");
            content += "," + tuple.Item1 + "," + tuple.Item2 + "," + tuple.Item3 + "," + tuple.Item4;
            return content;
        }
        private static void SavingInFile(string path,string content) 
        {
            bool test = File.Exists(path);
            File.AppendAllText(path, content);
           
        }
    }
}
