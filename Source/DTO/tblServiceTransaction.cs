using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class tblServiceTransaction
    {
        public int Card_ID { get; set; }
        public System.DateTime ServiceDate { get; set; }
        public int ServicePlace_ID { get; set; }
        public string ServiceDescription { get; set; }
        public int ServiceAmount { get; set; }
        public int Increase_Decrease { get; set; }
        public bool AutoTransferInput { get; set; }
        public int PointRule_ID { get; set; }
        public int? PointRec { get; set; }

        public tblServiceTransaction()
        {
            Card_ID = 0;
            ServiceDate = DateTime.Now;
            ServicePlace_ID = 0;
            ServiceDescription = "";
            ServiceAmount = 0;
            Increase_Decrease = 0;
            AutoTransferInput = false;
            PointRule_ID = 0;
            PointRec = (int?)null;
        }

        public tblServiceTransaction(System.Data.DataRow row)
        {
            Card_ID = row["Card_ID"].ToString() != "" ? Convert.ToInt32(row["Card_ID"]) : 0;
            ServiceDate = row["ServiceDate"].ToString() != "" ? Convert.ToDateTime(row["ServiceDate"]) : DateTime.Now;
            ServicePlace_ID = row["ServicePlace_ID"].ToString() != "" ? Convert.ToInt32(row["ServicePlace_ID"]) : 0;
            ServiceDescription = row["ServiceDescription"].ToString();
            ServiceAmount = row["ServiceAmount"].ToString() != "" ? Convert.ToInt32(row["ServiceAmount"]) : 0;
            Increase_Decrease = row["Increase_Decrease"].ToString() != "" ? Convert.ToInt32(row["Increase_Decrease"]) : 0;
            AutoTransferInput = row["AutoTransferInput"].ToString() != "" ? Convert.ToBoolean(row["AutoTransferInput"]) : false;
            PointRule_ID = row["PointRule_ID"].ToString() != "" ? Convert.ToInt32(row["PointRule_ID"]) : 0;
            PointRec = row["PointRec"].ToString() != "" ? Convert.ToInt32(row["PointRec"]) : (int?)null;
        }
    }
    public class tblServiceTransactionView
    {
        public int STT { get; set; }
        public System.DateTime ServiceDate { get; set; }
        public string PlaceName { get; set; }
        public string Increase_Decrease { get; set; }
        public int PointRec { get; set; }

        public tblServiceTransactionView()
        {
            STT = 0;
            ServiceDate = DateTime.Now;
            PlaceName = "";
            Increase_Decrease = "";
            PointRec = 0;
        }

        public tblServiceTransactionView(System.Data.DataRow row)
        {
            STT = row["STT"].ToString() != "" ? Convert.ToInt32(row["STT"]) : 0;
            ServiceDate = row["ServiceDate"].ToString() != "" ? Convert.ToDateTime(row["ServiceDate"]) : DateTime.Now;
            PlaceName = row["PlaceName"].ToString();
            Increase_Decrease = row["Increase_Decrease"].ToString();
            PointRec = row["PointRec"].ToString() != "" ? Convert.ToInt32(row["PointRec"]) : 0;
        }
    }
}
