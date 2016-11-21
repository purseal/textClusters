using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace bdProject
{
    class LoadTerminSurroundings: Connect
    {
        public OleDbCommand command;

        public LoadTerminSurroundings(string BDLocation, string tableName, Parameters param):base(BDLocation, tableName)
        {
            command = CreateCommand(tableName, param);
            SendCommand(command);
        }

        private OleDbCommand CreateCommand(string tableName, Parameters param)
        {
            String commandString;
            if (param.termSurPartOfSpeech == "")
            {
                /*
                commandString = "SELECT DISTINCT Термин, НормФорма FROM " + tableName + " WHERE НомерПредл=? AND " +
                    "(НомерСлова<>?) AND (?-НомерСлова)<=? AND (НомерСлова-?)<=?;";
                command = new OleDbCommand(commandString, connection);
                command.Parameters.Add("НомерПредл", OleDbType.VarChar).Value = param.sentNumber;
                command.Parameters.Add("НомерСлова", OleDbType.VarChar).Value = param.wordNumber;
                command.Parameters.Add("НомерСлова1", OleDbType.VarChar).Value = param.wordNumber;
                command.Parameters.Add("Расстояние", OleDbType.VarChar).Value = param.radius;
                command.Parameters.Add("НомерСлова2", OleDbType.VarChar).Value = param.wordNumber;
                command.Parameters.Add("Расстояние1", OleDbType.VarChar).Value = param.radius;
                */
                commandString = "SELECT A.НормФорма, Count(A.НормФорма) AS ЧастотаСовместнойВстречаемости FROM " + tableName +
                    " AS A, (SELECT НормФорма, НомерСлова, НомерПредл FROM " + tableName +
                    " WHERE НормФорма= '" + param.word + "') AS B WHERE A.НомерПредл = B.НомерПредл AND " +
                    "(A.НомерСлова <> B.НомерСлова) AND (A.НомерСлова BETWEEN(B.НомерСлова - " + param.radius +
                    ") AND (B.НомерСлова + " + param.radius + ")) GROUP BY A.НормФорма ORDER BY Count(A.НормФорма)DESC;";
                command = new OleDbCommand(commandString, connection);
                return command;
            }
            //if (param.termSurPartOfSpeech == null)
            //{
            //    commandString = "SELECT НормФорма, НомерСлова, НомерПредл FROM " + tableName +
            //        " WHERE НормФорма = '" + param.word + "' ORDER BY НомерПредл, НомерСлова;";
            //    command = new OleDbCommand(commandString, connection);
            //    return command;
            //}
            else
            {
                commandString = "SELECT A.НормФорма, Count(A.НормФорма) AS ЧастотаСовместнойВстречаемости FROM " + tableName +
                    " AS A, (SELECT НормФорма, НомерСлова, НомерПредл FROM " + tableName +
                    " WHERE НормФорма= '" + param.word + "') AS B WHERE A.НомерПредл = B.НомерПредл AND " +
                    "(A.НомерСлова <> B.НомерСлова) AND (A.НомерСлова BETWEEN(B.НомерСлова - " + param.radius +
                    ") AND (B.НомерСлова + " + param.radius + ")) AND ЧастьРечи = '" + param.termSurPartOfSpeech + 
                    "' GROUP BY A.НормФорма ORDER BY Count(A.НормФорма)DESC;"; 
                command = new OleDbCommand(commandString, connection);
                return command;
            }

        }
    }
}
