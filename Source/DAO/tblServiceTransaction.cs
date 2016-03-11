using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class tblServiceTransaction
    {
        public static List<DTO.tblServiceTransaction> Get()
        {
            List<DTO.tblServiceTransaction> lsArray = new List<DTO.tblServiceTransaction>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblServiceTransaction_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblServiceTransaction(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DTO.tblServiceTransactionView> GetView(int card_id)
        {
            List<DTO.tblServiceTransactionView> lsArray = new List<DTO.tblServiceTransactionView>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Card_ID", card_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblServiceTransaction_GetView", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblServiceTransactionView(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblServiceTransaction item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Card_ID", item.Card_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ServiceDate", item.ServiceDate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ServicePlace_ID", item.ServicePlace_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ServiceDescription", item.ServiceDescription));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ServiceAmount", item.ServiceAmount));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Increase_Decrease", item.Increase_Decrease));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@AutoTransferInput", item.AutoTransferInput));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@PointRule_ID", item.PointRule_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@PointRec", item.PointRec));
                result = conn.ExecuteNonQuery("sp_tblServiceTransaction_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete()
        {
            int result = 0;
            List<DTO.tblServiceTransaction> lsArray = new List<DTO.tblServiceTransaction>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                result = conn.ExecuteNonQuery("sp_tblServiceTransaction_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}
