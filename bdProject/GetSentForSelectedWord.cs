using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace bdProject
{
    class GetSentForSelectedWord : Connect
    {
        public OleDbCommand command;
        public int wordSentCount;

        public GetSentForSelectedWord(string BDLocation, string tableName, Parameters param):base(BDLocation, tableName)
        {
            command = CreateCommand(tableName, param);
            SendCommand(command);
        }

        private OleDbCommand CreateCommand(string tableName, Parameters param)
        {
            String commandString;
            commandString = "SELECT НормФорма, НомерПредл, НомерСлова FROM " + tableName +
                " WHERE НормФорма = '" + param.word + "' ORDER BY НомерПредл, НомерСлова;";                
            command = new OleDbCommand(commandString, connection);            
            return command;
        }


        public int[] GetFreqDestribution(GetSentForSelectedWord ts, int sentCount, int partitionCount)
        {
            DataRowCollection rows = ts.dataSet.Tables[0].Rows;
            int[] frqMas = new int[partitionCount];
            int k = 0;
    //        wordSentCount = rows.Count;
            for (int j = 0; j < rows.Count; j++)
            {
                while (Convert.ToInt32(rows[j][1]) > (k + 1) * (sentCount / partitionCount))
                {
                    k++;
                }
                if (k == partitionCount) frqMas[k - 1] += 1;
                else frqMas[k] += 1;
            }
            return frqMas;
        }

        public int[] GetFreqDestribution(GetSentForSelectedWord ts, int sentBegin, int sentCount, int partitionCount)
        {
            DataRowCollection rows = ts.dataSet.Tables[0].Rows;
            int[] frqMas = new int[partitionCount];
            int k = 0;
            //        wordSentCount = rows.Count;
            for (int j = 0; j < rows.Count; j++)
            {
                if (Convert.ToInt32(rows[j][1]) >= sentBegin && Convert.ToInt32(rows[j][1]) < sentBegin + sentCount)
                {
                    while (Convert.ToInt32(rows[j][1]) > (k + 1) * (sentCount / partitionCount) + sentBegin)
                    {
                        k++;
                    }
                    if (k == partitionCount) frqMas[k - 1] += 1;
                    else frqMas[k] += 1;
                }
            }
            return frqMas;
        }
    }
}
