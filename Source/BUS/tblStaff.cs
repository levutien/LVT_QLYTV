using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class tblStaff
    {
        public static List<DTO.tblStaff> GetAll()
        {
            return DAO.tblStaff.Get("");
        }

        public static DTO.tblStaff GetByID(string staffid)
        {
            return DAO.tblStaff.Get(staffid).FirstOrDefault();
        }

        public static int Create(DTO.tblStaff item)
        {
            return DAO.tblStaff.Create(item);
        }

        public static int Delete(string staffid)
        {
            return DAO.tblStaff.Delete(staffid);
        }
        public static System.Data.DataTable Login(string staffid, string accessCode)
        {
            return DAO.tblStaff.Login(staffid, accessCode);
        }
    }
}
