using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblDoctor
    {
        public static List<DTO.tblDoctor> Get(int doctor_id)
        {
            List<DTO.tblDoctor> lsArray = new List<DTO.tblDoctor>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Doctor_ID", doctor_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblDoctor_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblDoctor(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblDoctor item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Doctor_ID", item.Doctor_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@FullName", item.FullName));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ShortName", item.ShortName));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Gender_ID", item.Gender_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@YOB", item.YOB));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@AddressLine1", item.AddressLine1));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@AddressLine2", item.AddressLine2));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@MobilePhone", item.MobilePhone));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Phone2", item.Phone2));
                result = conn.ExecuteNonQuery("sp_tblDoctor_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int doctor_id)
        {
            int result = 0;
            List<DTO.tblDoctor> lsArray = new List<DTO.tblDoctor>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Doctor_ID", doctor_id));
                result = conn.ExecuteNonQuery("sp_tblDoctor_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}