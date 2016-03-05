using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblBookingStatus
    {
        public static List<DTO.tblBookingStatus> GetAll()
        {
            return DAO.tblBookingStatus.Get(0);
        }

        public static DTO.tblBookingStatus GetByID(int statusbooking_id)
        {
            return DAO.tblBookingStatus.Get(statusbooking_id).FirstOrDefault();
        }

        public static int Create(DTO.tblBookingStatus item)
        {
            return DAO.tblBookingStatus.Create(item);
        }

        public static int Delete(int statusbooking_id)
        {
            return DAO.tblBookingStatus.Delete(statusbooking_id);
        }
    }
}