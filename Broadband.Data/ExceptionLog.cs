using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadband.Data
{
   public class ExceptionLog
    {
       public static void WriteLog()
       {
           Console.WriteLine("Log added in DB @" + DateTime.Now.ToLongTimeString());
       }
    }
}
