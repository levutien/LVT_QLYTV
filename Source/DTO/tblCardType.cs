using System;

namespace DTO
{
    public class tblCardType
    {
        public int CardType_ID { get; set; }
        public string Description { get; set; }

        public tblCardType()
        {
            CardType_ID = 0;
            Description = "";
        }

        public tblCardType(System.Data.DataRow row)
        {
            CardType_ID = row["CardType_ID"].ToString() != "" ? Convert.ToInt32(row["CardType_ID"]) : 0;
            Description = row["Description"].ToString();
        }
    }
}