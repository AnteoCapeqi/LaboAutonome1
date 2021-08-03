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
            string[] arrayContent = content.Split(" , ");
            string[] fList;
            for (int i = 0; i < arrayContent.Length; i += 6)
            {
                fList = new string[6];
                for (int u = 0; u < 6; u++)
                {
                    fList[u] = arrayContent[i + u];
                }
                
            }
            return listContent;
            
        }
    }
}
