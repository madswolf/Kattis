using System;
using System.Data;
using System.Data.SqlClient;
using Npgsql;


namespace kattis
{
    class SortOfSorting
    {
        static void Main(string[] args)
        {
            var connectionString =
                "Server=localhost;" +
                "User Id=postgres;" +
                "Port=5432;" +
                "Password=Plet7913;" +
                "Database=HW3;";

            var conn = new NpgsqlConnection(connectionString);

            conn.Open();


           
            var rentalsColumns = new String[] {"PID","HID","PN","S","HS","HZ","HC"};
            var boatsColumns = new String[] { "BL", "BNo", "Z", "T", "BN", "SSN"};

            var table = "rentals";
            foreach(var item in rentalsColumns)
            {
                foreach(var thing in rentalsColumns)
                {
                    if (thing == item) continue;

                    var sql = $"select check_function('{table}','{thing}','{item}');";
                    var da = new NpgsqlDataAdapter(sql, conn);
                    var ds = new DataSet();

                     da.Fill(ds);

                    foreach(DataRow row in ds.Tables[0].Rows)
                    {
                        foreach (var x in row.ItemArray)
                        {
                            if (x.ToString().Equals("")) Console.WriteLine($"There might be a functional dependency between {thing} and {item}!");
                        }
                    }
                    
                }
            }

            table = "boats";
            foreach (var item in boatsColumns)
            {
                foreach (var thing in boatsColumns)
                {
                    if (thing == item) continue;

                    var sql = $"select check_function('{table}','{thing}','{item}');";
                    var da = new NpgsqlDataAdapter(sql, conn);
                    var ds = new DataSet();

                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        foreach (var x in row.ItemArray)
                        {
                            if (x.ToString().Equals("")) Console.WriteLine($"There might be a functional dependency between {thing} and {item}!");
                        }
                    }

                }
            }
            Console.WriteLine("done");

            Console.ReadLine();
        }

    }
}