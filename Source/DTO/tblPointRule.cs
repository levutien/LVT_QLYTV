using System;

namespace DTO
{
    public class tblPointRule
    {
        public int Rule_ID { get; set; }
        public string Description { get; set; }
        public int ChangeRate { get; set; }
        public int? Increase_Decrease { get; set; }

        public tblPointRule()
        {
            Rule_ID = 0;
            Description = "";
            ChangeRate = 0;
            Increase_Decrease = 0;
        }

        public tblPointRule(System.Data.DataRow row)
        {
            Rule_ID = row["Rule_ID"].ToString() != "" ? Convert.ToInt32(row["Rule_ID"]) : 0;
            Description = row["Description"].ToString();
            ChangeRate = row["ChangeRate"].ToString() != "" ? Convert.ToInt32(row["ChangeRate"]) : 0;
            Increase_Decrease = row["Increase_Decrease"].ToString() != "" ? Convert.ToInt32(row["Increase_Decrease"]) : 0;
        }
    }
}