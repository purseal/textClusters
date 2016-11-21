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

        public GetSentForSelectedWord(string BDLocation, string tableName, Parameters param):base(BDLocation, tableName)
        {
            command = CreateCommand(tableName, param);
            SendCommand(command);
        }

        private OleDbCommand CreateCommand(string tableName, Parameters param)
        {
            String commandString;
            commandString = "SELECT DISTINCT НормФорма, НомерПредл FROM " + tableName +
                " WHERE НормФорма = '" + param.word + "' ORDER BY НомерПредл;";                
            command = new OleDbCommand(commandString, connection);            
            return command;
        }


        public int[] GetFreqDestribution(GetSentForSelectedWord ts, int sentCount)
        {
            DataRowCollection rows = ts.dataSet.Tables[0].Rows;
            int[] frqMas = new int[10];
            int k = 0;
            for (int j = 0; j < rows.Count; j++)
            {
                while (Convert.ToInt32(rows[j][1]) > (k + 1) * (sentCount / 10))
                {
                    k++;
                }
                if (k == 10) frqMas[k - 1] += 1;
                else frqMas[k] += 1;
            }
            return frqMas;
        }
    }
}
