using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
//-----------------------------------
using System.Data.OleDb;

namespace bdProject
{
    class LoadFullTable: Connect
    {
        public OleDbCommand command;
        
      public LoadFullTable(string BDLocation, string tableName, Parameters param) :base(BDLocation, tableName)
        {
            command = CreateCommand(tableName, param);
            SendCommand(command);
        }

        private OleDbCommand CreateCommand(string tableName, Parameters param)
        {
            String commandString;
            if (param.PartOfSpeech == null && param.sentNumber == "")
            {
                commandString = "SELECT НормФорма, Count(НормФорма) AS Частота FROM " + tableName +
                    " GROUP BY НормФорма ORDER BY Count(НормФорма) DESC;";
                command = new OleDbCommand(commandString, connection);
            }
            else
            {
                commandString = "SELECT НормФорма, Count(НормФорма) AS Частота FROM " + tableName + " WHERE ";
                if (param.PartOfSpeech != null & param.sentNumber == "")
                    commandString += "ЧастьРечи='" + param.PartOfSpeech + "'";
                if (param.sentNumber != "" & param.PartOfSpeech == null)
                    commandString += "НомерПредл=" + param.sentNumber;
                if (param.PartOfSpeech != null & param.sentNumber != "")
                    commandString += "ЧастьРечи='" + param.PartOfSpeech + "'" + " AND НомерПредл=" + param.sentNumber;
                commandString += " GROUP BY НормФорма ORDER BY Count(НормФорма) DESC;";
                command = new OleDbCommand(commandString, connection);
            }
            return command;
        }
    }
}
