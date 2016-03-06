using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblFrequency
    {
        public static List<DTO.tblFrequency> GetAll()
        {
            return DAO.tblFrequency.Get(0, 0);
        }

        public static DTO.tblFrequency GetByID(int doctor_id, int service_id)
        {
            return DAO.tblFrequency.Get(doctor_id, service_id).FirstOrDefault();
        }

        public static int Create(DTO.tblFrequency item)
        {
            return DAO.tblFrequency.Create(item);
        }

        public static int Delete(int doctor_id, int service_id)
        {
            return DAO.tblFrequency.Delete(doctor_id, service_id);
        }
    }
}