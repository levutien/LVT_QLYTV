using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblStatus
    {
        public static List<DTO.tblStatus> Get(int status_id)
        {
            List<DTO.tblStatus> lsArray = new List<DTO.tblStatus>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Status_ID", status_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblStatus_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblStatus(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblStatus item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Status_ID", item.Status_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Description", item.Description));
                result = conn.ExecuteNonQuery("sp_tblStatus_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int status_id)
        {
            int result = 0;
            List<DTO.tblStatus> lsArray = new List<DTO.tblStatus>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Status_ID", status_id));
                result = conn.ExecuteNonQuery("sp_tblStatus_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}