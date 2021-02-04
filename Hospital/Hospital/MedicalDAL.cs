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
    class MedicalDAL
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


        public DataTable conditionView(Medical m)
        {
            DataTable dt = new DataTable();
            con = new SqlConnection(connectionString);

            cmd.Connection = con;
            con.Open();
            try
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "selectcondition";

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

        public DataTable prescriptionView(Medical m)
        {
            DataTable dt = new DataTable();
            con = new SqlConnection(connectionString);

            cmd.Connection = con;
            con.Open();
            try
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "selectprescription";

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
                //   return null;
            }

        }

        public int insertPrescription(Medical m)
        {
            try
            {
                con = new SqlConnection(connectionString);
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertprescription";
                cmd.Parameters.AddWithValue("@PatientID", m.pId);
                cmd.Parameters.AddWithValue("@PrescriptionName", m.PrescriptionName);
                cmd.Parameters.AddWithValue("@Dosage", m.Dosage);


                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int insertCondition(Medical m)
        {
            try
            {
                con = new SqlConnection(connectionString);
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertcondition";
                cmd.Parameters.AddWithValue("@PatientID", m.cId);
                cmd.Parameters.AddWithValue("@ConditionName", m.Name);

                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int deleteCondition(Medical m)
        {
            try
            {
                con = new SqlConnection(connectionString);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deletecondition";

                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@PatientID", m.cId);
                cmd.Parameters.AddWithValue("@ConditionName", m.Name);


                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deletePrescription(Medical m)
        {
            try
            {
                con = new SqlConnection(connectionString);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteprescription";

                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@PatientID", m.pId);
                cmd.Parameters.AddWithValue("@PrescriptionName", m.PrescriptionName);
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
