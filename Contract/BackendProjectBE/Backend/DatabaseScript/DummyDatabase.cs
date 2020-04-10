using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendProjectBE.DatabaseScript
{
    public class DummyDatabase
    {
        private static string connectionString = "Server=tcp:myservereasj.database.windows.net,1433;Initial Catalog=mydatabase;Persist Security Info=False;User ID=Serveradmin;Password=Test12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection myConn = new SqlConnection(connectionString);

        public void GetDatabases()
        {
            myConn.Open();
            TableCreation();
        }

        private void TableCreation()
        {
            string superQ =
                @"                                      -- MSSQL VERSION --

                -- CREATE TABELS --

                    --Create Customer table
                   CREATE TABLE [dbo].[Customer]
                    (
	                    [customerId] INT NOT NULL PRIMARY KEY IDENTITY, 
                        [cpr] NCHAR(100) NULL, 
                        [name] NCHAR(100) NULL
                    ) 

                   --Create Bank table
                   CREATE TABLE [dbo].[Bank]
                    CREATE TABLE [dbo].[Bank] (
                        [bankId]   INT         IDENTITY (1, 1) NOT NULL,
                        [cvr]  NCHAR (100) NULL,
                        [name] NCHAR (100) NULL,
                        [accountId] INT NULL, 
                        PRIMARY KEY CLUSTERED ([bankId] ASC), 
                        CONSTRAINT [FK_Bank_Account] FOREIGN KEY ([accountId]) REFERENCES [Account]([accountId])
                    );

                   --Create Account table
                   CREATE TABLE [dbo].[Account] (
                        [accountId]      INT         IDENTITY (1, 1) NOT NULL,
                        [number]  NCHAR (100) NULL,
                        [balance] INT         NULL,
                        [bankId] INT NULL, 
                        PRIMARY KEY CLUSTERED ([accountId] ASC), 
                        CONSTRAINT [FK_Account_Bank] FOREIGN KEY ([bankId]) REFERENCES [Bank]([bankId]) 
                    );


                -- INSERT DATA --

                    INSERT INTO Customer (cpr, name) values ('111111111', 'Jonas');
                    INSERT INTO Customer (cpr, name) values ('222222222', 'Christoffer');
                    INSERT INTO Customer (cpr, name) values ('333333333', 'Ian');
                    INSERT INTO Customer (cpr, name) values ('444444444', 'Kasper');

                    INSERT INTO Account (number, balance, bankId) values ('40506070', 500, 1);
                    INSERT INTO Account (number, balance, bankId) values ('31315050', 1000, 2);
                    INSERT INTO Account (number, balance, bankId) values ('48784878', 2000, 3);
                    INSERT INTO Account (number, balance, bankId) values ('11223311', 3000, 4);
                
                        
                ";

            SqlCommand cmd = new SqlCommand(superQ, myConn);
            cmd.ExecuteNonQuery();
        }




    }
}
