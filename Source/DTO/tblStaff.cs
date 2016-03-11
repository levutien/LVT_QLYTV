using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
	public class tblStaff
	{
		public string StaffID { get; set; }
		public string StaffName { get; set; }
		public string AccessCode { get; set; }

		public tblStaff()
		{
			StaffID = "";
			StaffName = "";
			AccessCode = "";
		}

		public tblStaff(System.Data.DataRow row)
		{
			StaffID = row["StaffID"].ToString();
			StaffName = row["StaffName"].ToString();
			AccessCode = row["AccessCode"].ToString();
		}
	}
}
