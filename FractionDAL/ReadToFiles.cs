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
