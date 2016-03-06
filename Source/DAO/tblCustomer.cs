using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblCustomer
    {
        public static List<DTO.tblCustomer> Get(int customer_id)
        {
            List<DTO.tblCustomer> lsArray = new List<DTO.tblCustomer>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Customer_ID", customer_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblCustomer_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblCustomer(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblCustomer item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Customer_ID", item.Customer_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@FullName", item.FullName));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Gender_ID", item.Gender_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@DOB", item.DOB));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@YOB", item.YOB));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@AddressLine1", item.AddressLine1));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@AddressLine2", item.AddressLine2));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@MobilePhone", item.MobilePhone));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Phone2", item.Phone2));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Email", item.Email));
                result = conn.ExecuteNonQuery("sp_tblCustomer_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int customer_id)
        {
            int result = 0;
            List<DTO.tblCustomer> lsArray = new List<DTO.tblCustomer>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Customer_ID", customer_id));
                result = conn.ExecuteNonQuery("sp_tblCustomer_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}