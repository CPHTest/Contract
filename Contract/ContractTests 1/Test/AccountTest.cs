using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contract.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract.Interface;
using System.Security.Principal;
using BackendProjectBE.Dummy;

namespace Contract.Test.Tests
{
    [TestClass()]
    public class AccountTest
    {
        // Unit Test


        // Naming convention used in the project:
        // [the name of the tested method]_[expected input / tested state]_[expected behavior].
        // Mock objects:  Mock<Customer> customerJonas = new Mock<Customer>();

        [TestMethod()]
        public void testCreateAccount()
        {
            IBank bank = new BankDummy();
            ICustomer customer = new CustomerDummy();
            String number = null;
            IAccount account = new Account(bank, customer, number);
            Assert.IsNotNull(account);
        }


    //[TestMethod()]
    //    public void testCreateAccountWithBank()
    //    {
    //        Bank bank = new BankDummy();
    //        Customer customer = new CustomerDummy();
    //        String number = null;
    //        Account account = new Account(bank, customer, number);
    //        assertEquals(bank, account.getBank());
    //        assertNotNull(account.getBank());
    //    }

    //    [TestMethod()]
    //    public void testCreateAccountWithNumber()
    //    {
    //        Bank bank = new BankDummy();
    //        Customer customer = new CustomerDummy();
    //        String number = "ABC12345";
    //        Account account = new Account(bank, customer, number);
    //        assertEquals(number, account.getNumber());
    //        assertNotNull(account.getNumber());
    //    }

    //    [TestMethod()]
    //    public void testCreateAccountWithZeroBalance()
    //    {
    //        Bank bank = new BankDummy();
    //        Customer customer = new CustomerDummy();
    //        String number = "ABC12345";
    //        Account account = new Account(bank, customer, number);
    //        assertEquals(0L, account.getBalance());
    //    }

    //    [TestMethod()]
    //    public void testTransferPositiveAmount()
    //    {
    //        Bank bank = new BankDummy();
    //        Customer customer = new CustomerDummy();
    //        String number = "ABC12345";
    //        Account source = new Account(bank, customer, "SRC12345");
    //        Account target = new Account(bank, customer, "TGT12345");
    //        source.transfer(10000, target);
    //        assertEquals(-10000, source.getBalance());
    //        assertEquals(10000, target.getBalance());
    //    }

    //    [TestMethod()]
    //    public void testTransferPositiveAmountUsingNumber()
    //    {
    //        BankStub bank = new BankStub();
    //        Customer customer = new CustomerDummy();
    //        String targetNumber = "TGT12345";
    //        Account target = new Account(bank, customer, targetNumber);
    //        Account source = new Account(bank, customer, "SRC12345");
    //        bank.setAccount(target);

    //        source.transfer(10000, targetNumber);
    //        assertEquals(-10000, source.getBalance());
    //        assertEquals(10000, target.getBalance());
    //    }
    }
}
