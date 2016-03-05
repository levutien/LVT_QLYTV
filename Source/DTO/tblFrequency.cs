using System;

namespace DTO
{
    public class tblFrequency
    {
        public int Doctor_ID { get; set; }
        public int Service_ID { get; set; }
        public int Duration { get; set; }

        public tblFrequency()
        {
            Doctor_ID = 0;
            Service_ID = 0;
            Duration = 0;
        }

        public tblFrequency(System.Data.DataRow row)
        {
            Doctor_ID = row["Doctor_ID"].ToString() != "" ? Convert.ToInt32(row["Doctor_ID"]) : 0;
            Service_ID = row["Service_ID"].ToString() != "" ? Convert.ToInt32(row["Service_ID"]) : 0;
            Duration = row["Duration"].ToString() != "" ? Convert.ToInt32(row["Duration"]) : 0;
        }
    }
}