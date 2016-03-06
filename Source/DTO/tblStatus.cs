using System;

namespace DTO
{
    public class tblStatus
    {
        public int Status_ID { get; set; }
        public string Description { get; set; }

        public tblStatus()
        {
            Status_ID = 0;
            Description = "";
        }

        public tblStatus(System.Data.DataRow row)
        {
            Status_ID = row["Status_ID"].ToString() != "" ? Convert.ToInt32(row["Status_ID"]) : 0;
            Description = row["Description"].ToString();
        }
    }
}