using BackendProjectBE.DatabaseScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProjectBE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating database tabels and inserting data");
            DummyDatabase dummyDatabase = new DummyDatabase();
            dummyDatabase.GetDatabases();
            Console.WriteLine("Completed");
            Console.ReadLine();

        }
    }
}
