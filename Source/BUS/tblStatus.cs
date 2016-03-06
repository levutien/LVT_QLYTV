using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblStatus
    {
        public static List<DTO.tblStatus> GetAll()
        {
            return DAO.tblStatus.Get(0);
        }

        public static DTO.tblStatus GetByID(int status_id)
        {
            return DAO.tblStatus.Get(status_id).FirstOrDefault();
        }

        public static int Create(DTO.tblStatus item)
        {
            return DAO.tblStatus.Create(item);
        }

        public static int Delete(int status_id)
        {
            return DAO.tblStatus.Delete(status_id);
        }
    }
}