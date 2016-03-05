using System;

namespace DTO
{
    public class tblCustomer
    {
        public int Customer_ID { get; set; }
        public string FullName { get; set; }
        public int Gender_ID { get; set; }
        public System.DateTime? DOB { get; set; }
        public int? YOB { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string MobilePhone { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }

        public tblCustomer()
        {
            Customer_ID = 0;
            FullName = "";
            Gender_ID = 0;
            DOB = DateTime.Now;
            YOB = 0;
            AddressLine1 = "";
            AddressLine2 = "";
            MobilePhone = "";
            Phone2 = "";
            Email = "";
        }

        public tblCustomer(System.Data.DataRow row)
        {
            Customer_ID = row["Customer_ID"].ToString() != "" ? Convert.ToInt32(row["Customer_ID"]) : 0;
            FullName = row["FullName"].ToString();
            Gender_ID = row["Gender_ID"].ToString() != "" ? Convert.ToInt32(row["Gender_ID"]) : 0;
            DOB = row["DOB"].ToString() != "" ? Convert.ToDateTime(row["DOB"]) : DateTime.Now;
            YOB = row["YOB"].ToString() != "" ? Convert.ToInt32(row["YOB"]) : 0;
            AddressLine1 = row["AddressLine1"].ToString();
            AddressLine2 = row["AddressLine2"].ToString();
            MobilePhone = row["MobilePhone"].ToString();
            Phone2 = row["Phone2"].ToString();
            Email = row["Email"].ToString();
        }
    }
}