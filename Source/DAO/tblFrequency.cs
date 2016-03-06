using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblFrequency
    {
        public static List<DTO.tblFrequency> Get(int doctor_id, int service_id)
        {
            List<DTO.tblFrequency> lsArray = new List<DTO.tblFrequency>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Doctor_ID", doctor_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Service_ID", service_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblFrequency_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblFrequency(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblFrequency item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Doctor_ID", item.Doctor_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Service_ID", item.Service_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Duration", item.Duration));
                result = conn.ExecuteNonQuery("sp_tblFrequency_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int doctor_id, int service_id)
        {
            int result = 0;
            List<DTO.tblFrequency> lsArray = new List<DTO.tblFrequency>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Doctor_ID", doctor_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Service_ID", service_id));
                result = conn.ExecuteNonQuery("sp_tblFrequency_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}