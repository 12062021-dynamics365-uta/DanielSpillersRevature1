using System;
using System.Data.SqlClient;

namespace InsertIntodatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            //INSERT CUSTOMER DATA TO SQL TABLE
            try
            {
                string str = "Data source = DANIELSPILLERSH\\SQLEXPRESS; initial Catalog = Project 0; integrated security= true";
                using (SqlConnection con = new SqlConnection(str))
                {
                SqlCommand cmd = new SqlCommand("Insert into Customers values('danny', 'anthony', 'dspill', '1234das', '122 blah drive', 'apt 1', 'new york', 'ny', 'usa', '10001')", con);
                    con.Open();
                    int row = cmd.ExecuteNonQuery();
                    Console.WriteLine("inserted row" + row);

                    //UPDATE CUSTOMER DATA TO TABLE

                    cmd.CommandText = "update Customers set Zipcode = 07304 where State = 'NJ'";
                    row = cmd.ExecuteNonQuery();
                    Console.WriteLine("Updated rows" + row);

                    //DELETE DATA FROM TABLE
                    cmd.CommandText = "Delete from Customers where firstName = 'danny'";
                    row = cmd.ExecuteNonQuery();
                    Console.WriteLine("Deleted row" + row);
                }
            } catch (Exception e)
            {
                Console.WriteLine("Something went wrong." + e);
            }
        }
    }
}
