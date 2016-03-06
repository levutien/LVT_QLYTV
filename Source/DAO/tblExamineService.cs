using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblExamineService
    {
        public static List<DTO.tblExamineService> Get(int service_id)
        {
            List<DTO.tblExamineService> lsArray = new List<DTO.tblExamineService>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Service_ID", service_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblExamineService_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblExamineService(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblExamineService item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Service_ID", item.Service_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ServiceName", item.ServiceName));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@InActive", item.InActive));
                result = conn.ExecuteNonQuery("sp_tblExamineService_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int service_id)
        {
            int result = 0;
            List<DTO.tblExamineService> lsArray = new List<DTO.tblExamineService>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Service_ID", service_id));
                result = conn.ExecuteNonQuery("sp_tblExamineService_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}