using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionBLL
{
    public class GetLogsFromDAL
    {
        public static List<ArithLogs> GetArtithLogs() 
        {
            List<string[]> content = FractionDAL.ReadToFiles.GetDataInFileLinq(true);
            List<ArithLogs> logs = new List<ArithLogs>();
            foreach (var item in content)
            {
                ArithLogs tempLog = new ArithLogs(item[0], item[1], item[2], item[3], item[4], item[5]);
                logs.Add(tempLog);
            }
            return logs;
        }
        public static List<CompaLogs> GetCompaLogs()
        {
            List<string[]> content = FractionDAL.ReadToFiles.GetDataInFileLinq(false);
            List<CompaLogs> logs = new List<CompaLogs>();
            foreach (var item in content)
            {
                CompaLogs tempLog = new CompaLogs(item[0], item[1], item[2], item[3], item[4], item[5]);
                logs.Add(tempLog);
            }
            return logs;
        }
    }
}
