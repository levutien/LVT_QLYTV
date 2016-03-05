using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblScheduleProvide
    {
        public static List<DTO.tblScheduleProvide> Get(int schedule_id)
        {
            List<DTO.tblScheduleProvide> lsArray = new List<DTO.tblScheduleProvide>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Schedule_ID", schedule_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblScheduleProvide_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblScheduleProvide(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblScheduleProvide item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Schedule_ID", item.Schedule_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Place_ID", item.Place_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Doctor_ID", item.Doctor_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ScheduleDate", item.ScheduleDate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Shift_ID", item.Shift_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@StartTime", item.StartTime));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@EndTime", item.EndTime));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Status", item.Status));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Capacity", item.Capacity));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@BookingCount", item.BookingCount));
                result = conn.ExecuteNonQuery("sp_tblScheduleProvide_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int schedule_id)
        {
            int result = 0;
            List<DTO.tblScheduleProvide> lsArray = new List<DTO.tblScheduleProvide>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Schedule_ID", schedule_id));
                result = conn.ExecuteNonQuery("sp_tblScheduleProvide_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}