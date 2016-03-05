using System;

namespace DTO
{
    public class tblExamineBooking
    {
        public int Customer_ID { get; set; }
        public int Schedule_ID { get; set; }
        public int Doctor_ID { get; set; }
        public int Service_ID { get; set; }
        public System.DateTime? BookingCreateDate { get; set; }
        public System.DateTime? EstimateStartTime { get; set; }
        public System.DateTime? EstimateEndTime { get; set; }
        public int? PositionIndex { get; set; }
        public int? StatusBooking_ID { get; set; }

        public tblExamineBooking()
        {
            Customer_ID = 0;
            Schedule_ID = 0;
            Doctor_ID = 0;
            Service_ID = 0;
            BookingCreateDate = DateTime.Now;
            EstimateStartTime = DateTime.Now;
            EstimateEndTime = DateTime.Now;
            PositionIndex = 0;
            StatusBooking_ID = 0;
        }

        public tblExamineBooking(System.Data.DataRow row)
        {
            Customer_ID = row["Customer_ID"].ToString() != "" ? Convert.ToInt32(row["Customer_ID"]) : 0;
            Schedule_ID = row["Schedule_ID"].ToString() != "" ? Convert.ToInt32(row["Schedule_ID"]) : 0;
            Doctor_ID = row["Doctor_ID"].ToString() != "" ? Convert.ToInt32(row["Doctor_ID"]) : 0;
            Service_ID = row["Service_ID"].ToString() != "" ? Convert.ToInt32(row["Service_ID"]) : 0;
            BookingCreateDate = row["BookingCreateDate"].ToString() != "" ? Convert.ToDateTime(row["BookingCreateDate"]) : DateTime.Now;
            EstimateStartTime = row["EstimateStartTime"].ToString() != "" ? Convert.ToDateTime(row["EstimateStartTime"]) : DateTime.Now;
            EstimateEndTime = row["EstimateEndTime"].ToString() != "" ? Convert.ToDateTime(row["EstimateEndTime"]) : DateTime.Now;
            PositionIndex = row["PositionIndex"].ToString() != "" ? Convert.ToInt32(row["PositionIndex"]) : 0;
            StatusBooking_ID = row["StatusBooking_ID"].ToString() != "" ? Convert.ToInt32(row["StatusBooking_ID"]) : 0;
        }
    }
}