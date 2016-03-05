using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblScheduleProvide
    {
        public static List<DTO.tblScheduleProvide> GetAll()
        {
            return DAO.tblScheduleProvide.Get(0);
        }

        public static DTO.tblScheduleProvide GetByID(int schedule_id)
        {
            return DAO.tblScheduleProvide.Get(schedule_id).FirstOrDefault();
        }

        public static int Create(DTO.tblScheduleProvide item)
        {
            return DAO.tblScheduleProvide.Create(item);
        }

        public static int Delete(int schedule_id)
        {
            return DAO.tblScheduleProvide.Delete(schedule_id);
        }
    }
}