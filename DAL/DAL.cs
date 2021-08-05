using BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessLayer
    {
        private SqlConnection con;
        //Handle Connection related Activities
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["Incident"].ToString();
            con = new SqlConnection(constr);
        }
        //Add Incident Details
        public bool AddIncident(cIncident obj)
        {
            connection();
            SqlCommand com = new SqlCommand("sp_AddIncident", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Incident", obj.Incident);
            com.Parameters.AddWithValue("@IncidentPhone", obj.IncidentPhone);
            com.Parameters.AddWithValue("@IncidentName", obj.IncidentName);
            com.Parameters.AddWithValue("@Time", DateTime.UtcNow);
            com.Parameters.AddWithValue("@IncidentLocation",obj.IncidentLocation);
            com.Parameters.AddWithValue("@IncidentLatitude",obj.IncidentLatitude);
            com.Parameters.AddWithValue("@IncidentLongtitude",obj.IncidentLongtitude);
            com.Parameters.AddWithValue("@Priority",obj.Priority);
            com.Parameters.AddWithValue("@IncidentType",obj.IncidentType);
            com.Parameters.AddWithValue("@infoLocation",obj.infoLocation);
            com.Parameters.AddWithValue("@infoLatittude",obj.infoLatitude);
            com.Parameters.AddWithValue("@infoLongtitude",obj.infoLongtitude);
            com.Parameters.AddWithValue("@NavigationNotes",obj.NavigationNotes);
            com.Parameters.AddWithValue("@SpecailConsiferation",obj.SpecialConsideration);
            com.Parameters.AddWithValue("@Casualties",obj.Casualties);
            com.Parameters.AddWithValue("@PatientName",obj.PatientName);
            com.Parameters.AddWithValue("@UniqueID",obj.UniqueID);
            com.Parameters.AddWithValue("@Age",obj.Age);
            com.Parameters.AddWithValue("@AgeUnit",obj.AgeUnit);
            com.Parameters.AddWithValue("@Gender",obj.Gender);
            com.Parameters.AddWithValue("@PatientPhone",obj.PatientPhone);
            com.Parameters.AddWithValue("@PatienNotes",obj.PatientNotes);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
