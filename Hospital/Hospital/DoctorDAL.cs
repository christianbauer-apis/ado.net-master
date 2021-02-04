using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Hospital
{
    class DoctorDAL
    {
        public SqlConnection con;

        public string connectionString = ConfigurationManager.ConnectionStrings["Hospital"].ToString();
        SqlCommand cmd = new SqlCommand();
        public SqlConnection GetConnection()
        {
            if (con == null)
                con = new SqlConnection(connectionString);
            return con;
        }

        public void Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void Close()
        {
            con.Close();
        }

        public DataTable getDoctor()
        {
            DataTable dt = new DataTable();
            con = new SqlConnection(connectionString);

            cmd.Connection = con;
            con.Open();
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "selectalldoctor";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                }
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        public DataTable showDoctors()
        {

            DataTable dt = new DataTable();
            con = new SqlConnection(connectionString);
            cmd.Connection = con;
            con.Open();

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectDoctor";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                }
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

    public int updateDoctor(Doctor d)
        {

            try
            {
                con = new SqlConnection(connectionString);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updatedoctor";

                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@DoctorID", d.Id);
                cmd.Parameters.AddWithValue("@Phone", d.Phone);
                cmd.Parameters.AddWithValue("@Name", d.Name);
                cmd.Parameters.AddWithValue("@Title", d.Title);
                cmd.Parameters.AddWithValue("@Address", d.Address);
                int i = cmd.ExecuteNonQuery();

                con.Close();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    public int updateDoctorAvailability(Doctor d)
    {
        try
        {
            con = new SqlConnection(connectionString);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updateavailability";

            cmd.Connection = con;
            con.Open();
            cmd.Parameters.AddWithValue("@DoctorID", d.Id);
            cmd.Parameters.AddWithValue("@AvailabilityStart", d.StartDate);
            cmd.Parameters.AddWithValue("@AvailabilityEnd", d.EndDate);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }




    }
}
