using System;

namespace DTO
{
    public class tblServicePlace
    {
        public int Place_ID { get; set; }
        public string PlaceName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public tblServicePlace()
        {
            Place_ID = 0;
            PlaceName = "";
            Address = "";
            Tel = "";
        }

        public tblServicePlace(System.Data.DataRow row)
        {
            Place_ID = row["Place_ID"].ToString() != "" ? Convert.ToInt32(row["Place_ID"]) : 0;
            PlaceName = row["PlaceName"].ToString();
            Address = row["Address"].ToString();
            Tel = row["Tel"].ToString();
        }
    }
}