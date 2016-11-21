using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdProject
{
    class OleDbSendCommandException: Exception
    {
        public string message;
        public OleDbSendCommandException()
        {
            message = "Ошибка в запросе к базе данных.";
        }
    }
}
