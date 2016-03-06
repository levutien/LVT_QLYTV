using System;

namespace DTO
{
    public class tblExamineService
    {
        public int Service_ID { get; set; }
        public string ServiceName { get; set; }
        public bool InActive { get; set; }

        public tblExamineService()
        {
            Service_ID = 0;
            ServiceName = "";
            InActive = false;
        }

        public tblExamineService(System.Data.DataRow row)
        {
            Service_ID = row["Service_ID"].ToString() != "" ? Convert.ToInt32(row["Service_ID"]) : 0;
            ServiceName = row["ServiceName"].ToString();
            InActive = row["InActive"].ToString() != "" ? Convert.ToBoolean(row["InActive"]) : false;
        }
    }
}