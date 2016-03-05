using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblServicePlace
    {
        public static List<DTO.tblServicePlace> Get(int place_id)
        {
            List<DTO.tblServicePlace> lsArray = new List<DTO.tblServicePlace>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Place_ID", place_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblServicePlace_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblServicePlace(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblServicePlace item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Place_ID", item.Place_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@PlaceName", item.PlaceName));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Address", item.Address));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Tel", item.Tel));
                result = conn.ExecuteNonQuery("sp_tblServicePlace_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int place_id)
        {
            int result = 0;
            List<DTO.tblServicePlace> lsArray = new List<DTO.tblServicePlace>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Place_ID", place_id));
                result = conn.ExecuteNonQuery("sp_tblServicePlace_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}