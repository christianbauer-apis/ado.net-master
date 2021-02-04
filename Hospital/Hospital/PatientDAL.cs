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
    class PatientDAL
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

        public int getPID()
        {
            try
            {
               
                con = new SqlConnection(connectionString);
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getid";
                cmd.Parameters.Clear();
            
                int patientID = (int)cmd.ExecuteScalar();

                

                con.Close();
                return patientID;
            }
            catch (Exception es)
            {
                throw es;
            }
        
        }

        public int insertPatient(Patient p)
        {
            try
            {
                con = new SqlConnection(connectionString);
                cmd.Connection = con;
                con.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertpatient";
                cmd.Parameters.AddWithValue("@Name", p.Name);
                cmd.Parameters.AddWithValue("@Address", p.Address);
                cmd.Parameters.AddWithValue("@Phone", p.Phone);
                cmd.Parameters.AddWithValue("@DoB", p.DoB);
                cmd.Parameters.AddWithValue("@AdmitDate", p.AdmitDate);
                cmd.Parameters.AddWithValue("@DischargeDate", p.DischargeDate);

                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int admitPatient(Patient p)
        {
            try
            {
                con = new SqlConnection(connectionString);
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "admitpatient";
                cmd.Parameters.AddWithValue("@PatientID", p.ID);
                cmd.Parameters.AddWithValue("@AdmitDate", p.Date);
                int i = cmd.ExecuteNonQuery();

                con.Close();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int dischargePatient(Patient p)
        {

            try
            {
                con = new SqlConnection(connectionString);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dischargepatient";

                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@PatientID", p.ID);
                cmd.Parameters.AddWithValue("@DischargeDate", p.Date);
                int i = cmd.ExecuteNonQuery();

                con.Close();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int updatePatient(Patient p)
        {

            try
            {
                con = new SqlConnection(connectionString);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updatepatient";

                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@Name", p.Name);
                cmd.Parameters.AddWithValue("@Address", p.Address);
                cmd.Parameters.AddWithValue("@Phone", p.Phone);
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
