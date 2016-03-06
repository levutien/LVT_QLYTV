using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblExamineService
    {
        public static List<DTO.tblExamineService> GetAll()
        {
            return DAO.tblExamineService.Get(0);
        }

        public static DTO.tblExamineService GetByID(int service_id)
        {
            return DAO.tblExamineService.Get(service_id).FirstOrDefault();
        }

        public static int Create(DTO.tblExamineService item)
        {
            return DAO.tblExamineService.Create(item);
        }

        public static int Delete(int service_id)
        {
            return DAO.tblExamineService.Delete(service_id);
        }
    }
}