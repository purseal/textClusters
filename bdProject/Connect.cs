using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace bdProject
{
    class Connect
    {
        public OleDbConnection connection;
        public DataSet dataSet = new DataSet();
        //public struct Paramet
        //{
        //    public string PartOfSpeech;
        //    public string termSurPartOfSpeech;
        //    public string wordNumber;
        //    public string sentNumber;
        //    public string radius;

        //    public Paramet(string PartOfSpeech, string termSurPartOfSpeech, string wordNumber, string sentNumber, string radius)
        //    {
        //        this.PartOfSpeech = PartOfSpeech;
        //        this.radius = radius;
        //        this.sentNumber = sentNumber;
        //        this.termSurPartOfSpeech = termSurPartOfSpeech;
        //        this.wordNumber = wordNumber;
        //    }
        //}

        public Connect(string BDLocation, string tableName)
        {
            String connectionString = @"Provider=Microsoft.Ace.OleDb.12.0;Data Source=" +
                BDLocation;
            try
            {
                connection = new OleDbConnection(connectionString);                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                connection.Open();
            }
            catch (OleDbException e)
            {
                Console.WriteLine("Error in connection : " + e.Message);
           //     throw new OleDbConnectionException(BDLocation);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in connection : " + ex.Message);
                connection.Close();
            }
        }

        public void SendCommand(OleDbCommand command)
        {
         //   try
         //   {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                dataSet.Clear();
                dataAdapter.Fill(dataSet);
       /*     }
            catch (Exception ex)
            {
                Console.WriteLine("error in command: " + ex.Message);
       //         throw new OleDbSendCommandException();
            }
            finally
            {*/
                // dispose of open objects
                if (connection != null)
                    connection.Close();
            //       }
        }

        public OleDbCommand getSentCountCommand(string tableName)
        {
            string commandString = "SELECT Max(НомерПредл) FROM " + tableName + ";";
            return new OleDbCommand(commandString, connection);
        }
    }
}
