using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblGender
    {
        public static List<DTO.tblGender> GetAll()
        {
            return DAO.tblGender.Get(0);
        }

        public static DTO.tblGender GetByID(int gender_id)
        {
            return DAO.tblGender.Get(gender_id).FirstOrDefault();
        }

        public static int Create(DTO.tblGender item)
        {
            return DAO.tblGender.Create(item);
        }

        public static int Delete(int gender_id)
        {
            return DAO.tblGender.Delete(gender_id);
        }
    }
}