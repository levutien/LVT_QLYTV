using System;

namespace DTO
{
    public class tblGender
    {
        public int Gender_ID { get; set; }
        public string Description { get; set; }

        public tblGender()
        {
            Gender_ID = 0;
            Description = "";
        }

        public tblGender(System.Data.DataRow row)
        {
            Gender_ID = row["Gender_ID"].ToString() != "" ? Convert.ToInt32(row["Gender_ID"]) : 0;
            Description = row["Description"].ToString();
        }
    }
}