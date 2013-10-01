using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadband.Data
{
    public class DataAccess
    {
        public static void InsertData()
        {
            Console.WriteLine("Data inserted!!!");
        }

        public static void UpdatedData()
        {
            Console.WriteLine("Data updated!!!");
        }

        public static void GetData(int id)
        {
            Console.WriteLine("Get record for ID.");
        } 
    }
}
