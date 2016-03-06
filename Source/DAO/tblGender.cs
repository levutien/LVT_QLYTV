using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblGender
    {
        public static List<DTO.tblGender> Get(int gender_id)
        {
            List<DTO.tblGender> lsArray = new List<DTO.tblGender>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Gender_ID", gender_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblGender_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblGender(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblGender item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Gender_ID", item.Gender_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Description", item.Description));
                result = conn.ExecuteNonQuery("sp_tblGender_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int gender_id)
        {
            int result = 0;
            List<DTO.tblGender> lsArray = new List<DTO.tblGender>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Gender_ID", gender_id));
                result = conn.ExecuteNonQuery("sp_tblGender_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}