using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.Interface;
using BackendProjectBE.DatabaseScript;

namespace Contract.Test.Tests
{
    [TestClass()]
    public class DatabaseTest
    {
        DummyDatabase dummyDatabase = new DummyDatabase();
        //setting up the environment 
        public void setUp()
        {
            dummyDatabase.GetDatabases();
        }
        public void tearDown()
        {
            dummyDatabase.TableDeletion();
        }

        [TestMethod]
        public void ChangeAccountBalance_attributeCheck()
        {

            //Arrange
            setUp();

            //   SQL statements CRUD //

            //Select* from Account;
            //Select* from Bank;
            //Select* from Customer;


            //INSERT INTO  Bank(cvr, name) VALUES(4, 'Nordea');
            //SELECT* FROM Bank WHERE cvr = 4;

            //INSERT INTO Customer(cpr, name, bankId) VALUES('666666666', 'Mark', 6);
            //SELECT* FROM Customer WHERE cpr = '666666666';

            //DELETE FROM Customer WHERE cpr = '666666666';
            //SELECT* FROM Customer WHERE cpr = '666666666';

            //UPDATE Account
            //SET balance = 10000
            //WHERE accountId = 1;
            //SELECT* FROM Account WHERE accountId = 1;

            //TearDown all data
            tearDown();
        }
    }
}