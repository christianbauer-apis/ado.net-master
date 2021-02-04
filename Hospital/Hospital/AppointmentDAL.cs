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
    class AppointmentDAL
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



        public DataTable showAppointments(Appointment a)
        {
            DataTable dt = new DataTable();

            con = new SqlConnection(connectionString);

            cmd.Connection = con;
            con.Open();
            try
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "showappointment";

                cmd.Parameters.AddWithValue("@AppointmentID", a.ID);

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


      

        public int insertAppointment(Appointment a)
        {

            try
            {
                con = new SqlConnection(connectionString);
                cmd.Connection = con;
                con.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertappointment";
                cmd.Parameters.AddWithValue("@PatientID", a.PID);
                cmd.Parameters.AddWithValue("@DoctorID", a.DID);
                cmd.Parameters.AddWithValue("@AppointmentDate", a.Date);

                int i = cmd.ExecuteNonQuery();

                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int deleteAppointment(Appointment a)
        {
            try
            {
                con = new SqlConnection(connectionString);

                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteappointment";
                cmd.Parameters.AddWithValue("@AppointmentID", a.ID);
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
