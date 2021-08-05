using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionDAL
{
    public class ReadToFiles
    {
        public static List<string[]> GetDataInFileLinq(bool file)
        {
            CsvFileDescription inputFileDescription = new CsvFileDescription
            {
                SeparatorChar = ',',
                FirstLineHasColumnNames = true
            };

            CsvContext cc = new CsvContext();

            IEnumerable<LogsDal> logs;
            if (file == true)
            {
                logs =
                //cc.Read<LogsDal>("ArithLogs.csv", inputFileDescription);
                cc.Read<LogsDal>(SavingToFile.GetArithLogPath(), inputFileDescription);
            }
            else
            {
                logs =
                cc.Read<LogsDal>(SavingToFile.GetCompLogPath(), inputFileDescription);
            }
            List<LogsDal> LogsDalList = logs.ToList();
            List<string[]> tlist = new List<string[]>();
            foreach (LogsDal log in LogsDalList)
            {
                string[] a = new string[] {log.Date,log.Heure,log.Fraction1,log.Operant,log.Fraction2,log.Resultat};
                tlist.Add(a);
            }
            return tlist;
        }
        public static List<string[]> GetDataInFile(bool file)
        {
            string content;
            if (file == true)
            {
                content = File.ReadAllText(SavingToFile.GetArithLogPath());
            }
            else 
            {
                content = File.ReadAllText(SavingToFile.GetCompLogPath());
            }
            List<string[]> listContent = new List<string[]>();
            string[] arrayContent = content.Split("\n");
            string[] fList;
            for (int i = 1; i < arrayContent.Length ; i++)
            {
                fList = new string[6];
                fList = arrayContent[i].Split(",");
                listContent.Add(fList);
            }
            return listContent;
            
        }
    }
}
