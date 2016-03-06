using System;

namespace DTO
{
    public class tblBookingStatus
    {
        public int StatusBooking_ID { get; set; }
        public string StatusName { get; set; }

        public tblBookingStatus()
        {
            StatusBooking_ID = 0;
            StatusName = "";
        }

        public tblBookingStatus(System.Data.DataRow row)
        {
            StatusBooking_ID = row["StatusBooking_ID"].ToString() != "" ? Convert.ToInt32(row["StatusBooking_ID"]) : 0;
            StatusName = row["StatusName"].ToString();
        }
    }
}