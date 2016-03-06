using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblDoctor
    {
        public static List<DTO.tblDoctor> GetAll()
        {
            return DAO.tblDoctor.Get(0);
        }

        public static DTO.tblDoctor GetByID(int doctor_id)
        {
            return DAO.tblDoctor.Get(doctor_id).FirstOrDefault();
        }

        public static int Create(DTO.tblDoctor item)
        {
            return DAO.tblDoctor.Create(item);
        }

        public static int Delete(int doctor_id)
        {
            return DAO.tblDoctor.Delete(doctor_id);
        }
    }
}