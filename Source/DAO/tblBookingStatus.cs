using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblBookingStatus
    {
        public static List<DTO.tblBookingStatus> Get(int statusbooking_id)
        {
            List<DTO.tblBookingStatus> lsArray = new List<DTO.tblBookingStatus>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@StatusBooking_ID", statusbooking_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblBookingStatus_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblBookingStatus(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblBookingStatus item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@StatusBooking_ID", item.StatusBooking_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@StatusName", item.StatusName));
                result = conn.ExecuteNonQuery("sp_tblBookingStatus_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int statusbooking_id)
        {
            int result = 0;
            List<DTO.tblBookingStatus> lsArray = new List<DTO.tblBookingStatus>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@StatusBooking_ID", statusbooking_id));
                result = conn.ExecuteNonQuery("sp_tblBookingStatus_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}