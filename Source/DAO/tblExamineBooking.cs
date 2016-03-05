using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblExamineBooking
    {
        public static List<DTO.tblExamineBooking> Get(int customer_id, int schedule_id, int doctor_id, int service_id)
        {
            List<DTO.tblExamineBooking> lsArray = new List<DTO.tblExamineBooking>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Customer_ID", customer_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Schedule_ID", schedule_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Doctor_ID", doctor_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Service_ID", service_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblExamineBooking_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblExamineBooking(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblExamineBooking item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Customer_ID", item.Customer_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Schedule_ID", item.Schedule_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Doctor_ID", item.Doctor_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Service_ID", item.Service_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@BookingCreateDate", item.BookingCreateDate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@EstimateStartTime", item.EstimateStartTime));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@EstimateEndTime", item.EstimateEndTime));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@PositionIndex", item.PositionIndex));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@StatusBooking_ID", item.StatusBooking_ID));
                result = conn.ExecuteNonQuery("sp_tblExamineBooking_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int customer_id, int schedule_id, int doctor_id, int service_id)
        {
            int result = 0;
            List<DTO.tblExamineBooking> lsArray = new List<DTO.tblExamineBooking>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Customer_ID", customer_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Schedule_ID", schedule_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Doctor_ID", doctor_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Service_ID", service_id));
                result = conn.ExecuteNonQuery("sp_tblExamineBooking_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}