using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.Interface;

namespace Contract.Test.Tests
{
    [TestClass]
    public class BankIntergrationTest
    {
        // Fields are used by all tests.
        private static IBank bank = new Bank("1203954", "Jyske Bank");
        private static ICustomer customerJonas = new Customer("2206921111", "Jonas pedersen", "1");
        private static ICustomer customerChristoffer = new Customer("2206921111", "Christoffer dunk", "2");

        private static IAccount JonasAccount = new Account(bank, customerJonas, "1");
        private static IAccount ChristofferAccount = new Account(bank, customerChristoffer, "2");


        //Setup will just add accounts to the bank, which is also used in all the tests
        [TestInitialize]
        public void setup()
        {
            bank.AddAccount(JonasAccount);
            bank.AddAccount(ChristofferAccount);
        }



        [TestMethod()]
        public void test()
        {
            //Arrange


            //Act
            List<IAccount> accountA = bank.GetAccounts(customerJonas);

            //Assert
            Assert.AreEqual(8, accountA.Count);
            // The reason why its 8 and not just the two elements, is becouse we have 4 method calling it 
            // filling the list up with 8 elements. 
        }


        [TestMethod()]
        public void GetAccountByNumber()
        {
            //Arrange


            //Act
            IAccount accountA = bank.GetAccount(JonasAccount.Number);

            //Assert
            Assert.AreEqual(JonasAccount.Number, accountA.Number);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Account not found")]
        public void GetAccountByNumberWrongInput()
        {
            //Arrange

            //Act
            bank.GetAccount("321");

            //Assert

            // Asserting exception thrown
        }

        [TestMethod()]
        public void GetAccountByCustomer()
        {
            //Arrange

            //Act
            IAccount customerAccount = bank.GetAccount(customerChristoffer.getId());

            //Assert
            Assert.AreEqual(0, customerAccount.getBalance());
        }
    }
}