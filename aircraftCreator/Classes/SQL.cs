using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace aircraftCreator
{
    class SQL
    {
        public AircraftName[] GetList(int userID)
        {
            AircraftName[] allAircraft = null;
            List<string> myReturnedData = new List<string>();
            try
            {

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        String sql = "SELECT ID, Configuration_Name " +
                                        "FROM [dbo].[tbAircraftDesigner] " +
                                        "WHERE User_ID = " + userID;

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                var list = new List<AircraftName>();
                                while (reader.Read())
                                {
                                    list.Add(new AircraftName { ac_id = reader.GetInt32(0), ac_Name = reader.GetString(1) });
                                    allAircraft = list.ToArray();
                                }
                            }
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return allAircraft;
        }
        public bool InsertAircraft(string[] configuration)
        {
            bool success = false;
            string values = "";

            for (int i = 0; i < configuration.Length; i++)
            {
                if (i == configuration.Length - 1)
                {
                    values = values + "'" + configuration[i] + "'";
                }
                else
                {
                    values = values + "'" + configuration[i] + "',";
                }
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO [dbo].[tbAircraftDesigner] (User_ID,Configuration_Name,aircraft_Type,payload,velocity,range,prop_Config,wingspan,wing_Config,sweep_Angle,root_Cord,landing_Gear_Config,mission_Profile) VALUES (1," + values + ")";

                    SqlCommand Command = new SqlCommand(sql, connection);
                    int returnval = Command.ExecuteNonQuery();
                    if (returnval == 1)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return success;
        }
        public bool UpdateAircraft(string[] configuration)
        {
            bool success = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string sql = "UPDATE [dbo].[tbAircraftDesigner] " +
                        "SET User_ID =1" +
                        ",Configuration_Name='" + configuration[0] + "'" +
                        ",aircraft_Type=" + configuration[1] +
                        ",payload=" + configuration[2] +
                        ",velocity=" + configuration[3] +
                        ",range=" + configuration[4] +
                        ",prop_Config=" + configuration[5] +
                        ",wingspan=" + configuration[6] +
                        ",wing_Config=" + configuration[7] +
                        ",sweep_Angle=" + configuration[8] +
                        ",root_Cord=" + configuration[9] +
                        ",landing_Gear_Config=" + configuration[10] +
                        ",mission_Profile=" + configuration[11] +
                        " WHERE User_ID = 1 and Configuration_Name ='" + configuration[0] + "'";

                    SqlCommand Command = new SqlCommand(sql, connection);
                    int returnval = Command.ExecuteNonQuery();
                    if (returnval == 1)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return success;
        }
        public bool RemoveAircraft(int ac_id)
        {
            bool success = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM [dbo].[tbAircraftDesigner] where id = " + ac_id;

                    SqlCommand Command = new SqlCommand(sql, connection);
                    int returnval = Command.ExecuteNonQuery();
                    if (returnval == 1)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return success;
        }
        public DataTable getConfiguration(int configID)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString))
                {
                    try
                    {
                        connection.Open();
                        String sql = "SELECT " +
                                        "aircraft_Type, " +
                                        "payload, " +
                                        "velocity, " +
                                        "range," +
                                        "prop_Config," +
                                        "wingspan," +
                                        "wing_Config," +
                                        "sweep_Angle," +
                                        "root_Cord," +
                                        "landing_Gear_Config," +
                                        "mission_Profile " +
                                        "FROM [dbo].[tbAircraftDesigner] " +
                                        "WHERE ID = " + configID;

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                            {
                                dataAdapter.Fill(dataTable);
                            }
                        }
                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return dataTable;
        }
    }
}
