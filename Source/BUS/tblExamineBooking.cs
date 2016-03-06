using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblExamineBooking
    {
        public static List<DTO.tblExamineBooking> GetAll()
        {
            return DAO.tblExamineBooking.Get(0, 0, 0, 0);
        }

        public static DTO.tblExamineBooking GetByID(int customer_id, int schedule_id, int doctor_id, int service_id)
        {
            return DAO.tblExamineBooking.Get(customer_id, schedule_id, doctor_id, service_id).FirstOrDefault();
        }

        public static int Create(DTO.tblExamineBooking item)
        {
            return DAO.tblExamineBooking.Create(item);
        }

        public static int Delete(int customer_id, int schedule_id, int doctor_id, int service_id)
        {
            return DAO.tblExamineBooking.Delete(customer_id, schedule_id, doctor_id, service_id);
        }
    }
}