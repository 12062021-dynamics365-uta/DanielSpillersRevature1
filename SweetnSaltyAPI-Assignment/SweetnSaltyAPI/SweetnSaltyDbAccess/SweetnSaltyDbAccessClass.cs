using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyDbAccess
{
    public class SweetnSaltyDbAccessClass : ISweetnSaltyDbAccessClass
    {
        private readonly string str = "Data source = DANIELSPILLERSH\\SQLEXPRESS; initial Catalog = SweetnSalty; integrated security = true";
        private readonly SqlConnection _con;

        //constructor
        public SweetnSaltyDbAccessClass()
        {
            this._con = new SqlConnection(this.str);
            _con.Open();
        }


        public async Task<SqlDataReader> PostFlavor(string flavor)
        {
            string sqlQuery = "INSERT INTO Flavors VALUES (@Flavor);";

            using(SqlCommand cmd = new SqlCommand(sqlQuery, this._con))
            {
                cmd.Parameters.AddWithValue("@Flavor", flavor);
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    string retrieveFlavor = "SELECT TOP 1 * FROM Flavors ORDER BY FlavorId DESC;";
                    using(SqlCommand cmd2 = new SqlCommand(retrieveFlavor, _con))
                    {
                        SqlDataReader dr = await cmd2.ExecuteReaderAsync();
                        return dr;
                    }
                }
                catch (DbException ex)
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.PostFlavor {ex}");
                    return null;
                }
            }
        }
        public async Task<SqlDataReader> PostPerson(string fname, string lname)
        {
            string sqlQuery = "INSERT INTO Users VALUES (@FirstName, @LastName);";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, this._con))
            {
                cmd.Parameters.AddWithValue("@FirstName", fname);
                cmd.Parameters.AddWithValue("@LastName", lname);
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    string retrievePerson = "SELECT TOP 1 * FROM Users ORDER BY UserId DESC;";
                    using (SqlCommand cmd2 = new SqlCommand(retrievePerson, _con))
                    {
                        SqlDataReader dr = await cmd2.ExecuteReaderAsync();
                        return dr;
                    }
                }
                catch (DbException ex)
                {
                    Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.PostPerson {ex}");
                    return null;
                }
            }
        }

        public async Task<SqlDataReader> GetPerson(string fname, string lname)
        {
            string query = "SELECT * FROM Users WHERE FirstName = @FirstName AND LastName = @LastName;";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, this._con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", fname);
                    cmd.Parameters.AddWithValue("@LastName", lname);
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    return dr;
                }
            }
            catch (DbException ex)
            {
                Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.GetPerson {ex}");
                return null;
            }
        }


        public async Task<SqlDataReader> GetPersonAndFlavors(int id)
        {
            string query = "SELECT Users.UserID, Users.FirstName, Users.LastName, Flavors.FlavorID, FLavors.Flavor FROM Users " +
                           "JOIN UsersFlavors ON Users.UserID = UsersFlavors.UserID " +
                           "JOIN Flavors ON Flavors.FlavorID = UsersFlavors.FlavorID " +
                           "WHERE Users.UserID = @id;";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    return dr;
                }
            }
            catch (DbException ex)
            {
                Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.GetPersonAndFlavors {ex}");
                return null;
            }
        }


        public async Task<SqlDataReader> GetAllFlavors()
        {
            string query = "SELECT * From Flavors";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    return (dr);
                }
            }
            catch (DbException ex)
            {
                Console.WriteLine($"There was an exception in SweetnSaltyBusinessClass.GetAllFlavors {ex}");
                return null;
            }
        }

    }
}
