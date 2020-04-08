using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.DatabaseScript
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
                @"
                -- MSSQL VERSION --

                    --Create Customer table
                   CREATE TABLE [dbo].[Customer]
                    (
	                    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
                        [cpr] NCHAR(100) NULL, 
                        [name] NCHAR(100) NULL
                    ) 

                   --Create Bank table
                   CREATE TABLE [dbo].[Bank]
                    (
	                    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
                        [cvr] NCHAR(100) NULL, 
                        [name] NCHAR(100) NULL, 
                    )

                   --Create Account table
                   CREATE TABLE [dbo].[Account]
                    (
	                    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
                        [number] NCHAR(100) NULL, 
                        [balance] INT NULL, 
                    )

                        
                ";

            SqlCommand cmd = new SqlCommand(superQ, myConn);
            cmd.ExecuteNonQuery();
        }




    }
}
