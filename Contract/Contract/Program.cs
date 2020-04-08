using Contract.DatabaseScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyDatabase dummyDatabase = new DummyDatabase();
            dummyDatabase.GetDatabases();

            Console.WriteLine("database created");
            Console.ReadLine();
        }
    }
}
