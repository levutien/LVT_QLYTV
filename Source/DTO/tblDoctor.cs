using System;

namespace DTO
{
    public class tblDoctor
    {
        public int Doctor_ID { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public int Gender_ID { get; set; }
        public int? YOB { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string MobilePhone { get; set; }
        public string Phone2 { get; set; }

        public tblDoctor()
        {
            Doctor_ID = 0;
            FullName = "";
            ShortName = "";
            Gender_ID = 0;
            YOB = 0;
            AddressLine1 = "";
            AddressLine2 = "";
            MobilePhone = "";
            Phone2 = "";
        }

        public tblDoctor(System.Data.DataRow row)
        {
            Doctor_ID = row["Doctor_ID"].ToString() != "" ? Convert.ToInt32(row["Doctor_ID"]) : 0;
            FullName = row["FullName"].ToString();
            ShortName = row["ShortName"].ToString();
            Gender_ID = row["Gender_ID"].ToString() != "" ? Convert.ToInt32(row["Gender_ID"]) : 0;
            YOB = row["YOB"].ToString() != "" ? Convert.ToInt32(row["YOB"]) : 0;
            AddressLine1 = row["AddressLine1"].ToString();
            AddressLine2 = row["AddressLine2"].ToString();
            MobilePhone = row["MobilePhone"].ToString();
            Phone2 = row["Phone2"].ToString();
        }
    }
}