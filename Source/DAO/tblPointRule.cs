using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblPointRule
    {
        public static List<DTO.tblPointRule> Get(int rule_id)
        {
            List<DTO.tblPointRule> lsArray = new List<DTO.tblPointRule>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Rule_ID", rule_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblPointRule_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblPointRule(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblPointRule item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Rule_ID", item.Rule_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Description", item.Description));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ChangeRate", item.ChangeRate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Increase_Decrease", item.Increase_Decrease));
                result = conn.ExecuteNonQuery("sp_tblPointRule_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int rule_id)
        {
            int result = 0;
            List<DTO.tblPointRule> lsArray = new List<DTO.tblPointRule>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Rule_ID", rule_id));
                result = conn.ExecuteNonQuery("sp_tblPointRule_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}