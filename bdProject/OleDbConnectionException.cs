using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdProject
{
    class OleDbConnectionException: Exception
    {
        public string message;
        public OleDbConnectionException(string BDLocation):base()
        {
            if (BDLocation == "")
                message = "Выберите существующую базу данных.";
        }
           
    }
}
