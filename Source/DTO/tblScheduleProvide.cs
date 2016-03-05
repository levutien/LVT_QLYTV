using System;

namespace DTO
{
    public class tblScheduleProvide
    {
        public int Schedule_ID { get; set; }
        public int? Place_ID { get; set; }
        public int Doctor_ID { get; set; }
        public int ScheduleDate { get; set; }
        public int Shift_ID { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public int? Status { get; set; }
        public int? Capacity { get; set; }
        public int? BookingCount { get; set; }

        public tblScheduleProvide()
        {
            Schedule_ID = 0;
            Place_ID = 0;
            Doctor_ID = 0;
            ScheduleDate = 0;
            Shift_ID = 0;
            StartTime = DateTime.Now;
            EndTime = DateTime.Now;
            Status = 0;
            Capacity = 0;
            BookingCount = 0;
        }

        public tblScheduleProvide(System.Data.DataRow row)
        {
            Schedule_ID = row["Schedule_ID"].ToString() != "" ? Convert.ToInt32(row["Schedule_ID"]) : 0;
            Place_ID = row["Place_ID"].ToString() != "" ? Convert.ToInt32(row["Place_ID"]) : 0;
            Doctor_ID = row["Doctor_ID"].ToString() != "" ? Convert.ToInt32(row["Doctor_ID"]) : 0;
            ScheduleDate = row["ScheduleDate"].ToString() != "" ? Convert.ToInt32(row["ScheduleDate"]) : 0;
            Shift_ID = row["Shift_ID"].ToString() != "" ? Convert.ToInt32(row["Shift_ID"]) : 0;
            StartTime = row["StartTime"].ToString() != "" ? Convert.ToDateTime(row["StartTime"]) : DateTime.Now;
            EndTime = row["EndTime"].ToString() != "" ? Convert.ToDateTime(row["EndTime"]) : DateTime.Now;
            Status = row["Status"].ToString() != "" ? Convert.ToInt32(row["Status"]) : 0;
            Capacity = row["Capacity"].ToString() != "" ? Convert.ToInt32(row["Capacity"]) : 0;
            BookingCount = row["BookingCount"].ToString() != "" ? Convert.ToInt32(row["BookingCount"]) : 0;
        }
    }
}