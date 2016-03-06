using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblServicePlace
    {
        public static List<DTO.tblServicePlace> GetAll()
        {
            return DAO.tblServicePlace.Get(0);
        }

        public static DTO.tblServicePlace GetByID(int place_id)
        {
            return DAO.tblServicePlace.Get(place_id).FirstOrDefault();
        }

        public static int Create(DTO.tblServicePlace item)
        {
            return DAO.tblServicePlace.Create(item);
        }

        public static int Delete(int place_id)
        {
            return DAO.tblServicePlace.Delete(place_id);
        }
    }
}