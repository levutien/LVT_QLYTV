using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class tblStaff
    {
        public static List<DTO.tblStaff> Get(string staffid)
        {
            List<DTO.tblStaff> lsArray = new List<DTO.tblStaff>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@StaffID", staffid));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblStaff_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblStaff(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblStaff item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@StaffID", item.StaffID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@StaffName", item.StaffName));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@AccessCode", item.AccessCode));
                result = conn.ExecuteNonQuery("sp_tblStaff_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(string staffid)
        {
            int result = 0;
            List<DTO.tblStaff> lsArray = new List<DTO.tblStaff>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@StaffID", staffid));
                result = conn.ExecuteNonQuery("sp_tblStaff_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static System.Data.DataTable Login(string staffid, string accessCode)
        {
            ConnectionCRM conn = null;
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@StaffID", staffid));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@AccessCode", accessCode));
                dt = conn.ExecuteNonQueryData("sp_tblStaff_Login", lsInput);
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return dt;
        }
    }
}
