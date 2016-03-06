using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblCardType
    {
        public static List<DTO.tblCardType> Get(int cardtype_id)
        {
            List<DTO.tblCardType> lsArray = new List<DTO.tblCardType>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@CardType_ID", cardtype_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblCardType_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblCardType(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblCardType item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@CardType_ID", item.CardType_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Description", item.Description));
                result = conn.ExecuteNonQuery("sp_tblCardType_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int cardtype_id)
        {
            int result = 0;
            List<DTO.tblCardType> lsArray = new List<DTO.tblCardType>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@CardType_ID", cardtype_id));
                result = conn.ExecuteNonQuery("sp_tblCardType_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}