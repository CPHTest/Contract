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
        //Conection string to our Azure database. 
        private static string connectionString = "Server=tcp:myservereasj.database.windows.net,1433;Initial Catalog=mydatabase;Persist Security Info=False;User ID=Serveradmin;Password=Test12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection myConn = new SqlConnection(connectionString);

        public void GetDatabases()
        {
            //Trying to open a connection, if that going good we then proceed to create tabels 
            // and inserting data

            //myConn.Open();
            //TableCreation();

            try
            {
                myConn.Open();
                TableCreation();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
                myConn.Close();
                throw;
            }
        }

        // Containing all the SQL logic to create tabels and inserting data. 
        private void TableCreation()
        {
            string superQ =
                @"                                     

                    -- CREATE TABELS --

                       --Create Bank table
                        CREATE TABLE [dbo].[Bank] 
                        (
                            [bankId] INT IDENTITY (1, 1) NOT NULL,
                            [cvr]    NCHAR (100) NULL,
                            [name]   NCHAR (100) NULL, 
                            CONSTRAINT [PK_Bank] PRIMARY KEY ([bankId])
                        );

                    --Create Customer table
                       CREATE TABLE [dbo].[Customer]
                        (
	                        [customerId] INT IDENTITY (1, 1) NOT NULL,
                            [cpr] NCHAR(100) NULL, 
                        [name] NCHAR(100) NULL, 
                        [bankId] INT NULL, 
                        CONSTRAINT [PK_Customer] PRIMARY KEY ([customerId]),
                        CONSTRAINT [FK_Table_Bank] FOREIGN KEY ([bankId]) REFERENCES [Bank]([bankId]) 
                    )


                --Create Account table
                    CREATE TABLE [dbo].[Account] 
                    (
                        [accountId]  INT IDENTITY (1, 1) NOT NULL,
                        [number]  NCHAR (100) NULL,
                        [balance] INT         NULL,
                        [bankId] INT NULL, 
						[customerId] INT NULL,
                        CONSTRAINT [PK_Account] PRIMARY KEY ([accountId]),
                        CONSTRAINT [FK_Account_Bank] FOREIGN KEY ([bankId]) REFERENCES [Bank]([bankId]),
                        CONSTRAINT [FK_Account_Customer] FOREIGN KEY ([customerId]) REFERENCES [Customer]([customerId]) 
                    );


                -- INSERT DATA --

                    INSERT INTO Bank (cvr, name) values ('1', 'Danske banke');
                    INSERT INTO Bank (cvr, name) values ('2', 'Jyske banke');
                    INSERT INTO Bank (cvr, name) values ('2', 'arbejdernes landsbank');

                    INSERT INTO Customer (cpr, name, bankId) values ('111111111', 'Jonas', 1);
                    INSERT INTO Customer (cpr, name, bankId) values ('222222222', 'Christoffer', 1);
                    INSERT INTO Customer (cpr, name, bankId) values ('333333333', 'Ian', 1);
                    INSERT INTO Customer (cpr, name, bankId) values ('444444444', 'Kasper', 2);
                    INSERT INTO Customer (cpr, name, bankId) values ('555555555', 'Stine', 3);

                    INSERT INTO Account (number, balance, bankId, customerId) values ('40506070', 500, 1, 1);
                    INSERT INTO Account (number, balance, bankId, customerId) values ('31315050', 1000, 1, 2);
                    INSERT INTO Account (number, balance, bankId, customerId) values ('48784878', 2000, 1, 3);
                    INSERT INTO Account (number, balance, bankId, customerId) values ('11223311', 3000, 2, 4);
                    INSERT INTO Account (number, balance, bankId, customerId) values ('55115511', 5000, 3, 5);
                
                        
                ";

            // 'SqlCommand' allow us writes executable SQL code and afterwards call 'ExecuteNonQuery' to execute it.
            SqlCommand cmd = new SqlCommand(superQ, myConn);
            cmd.ExecuteNonQuery();
        }


        public void TableDeletion()
        {
            string superQ =
                @"

                -- DROP TABELS --
                    DROP TABLE Customer;
                    DROP TABLE Bank;
                    DROP TABLE Account;

                ";

            // 'SqlCommand' allow us writes executable SQL code and afterwards call 'ExecuteNonQuery' to execute it.
            SqlCommand cmd = new SqlCommand(superQ, myConn);
            cmd.ExecuteNonQuery();
        }
    }
}
