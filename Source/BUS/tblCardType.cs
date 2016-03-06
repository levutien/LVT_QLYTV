using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblCardType
    {
        public static List<DTO.tblCardType> GetAll()
        {
            return DAO.tblCardType.Get(0);
        }

        public static DTO.tblCardType GetByID(int cardtype_id)
        {
            return DAO.tblCardType.Get(cardtype_id).FirstOrDefault();
        }

        public static int Create(DTO.tblCardType item)
        {
            return DAO.tblCardType.Create(item);
        }

        public static int Delete(int cardtype_id)
        {
            return DAO.tblCardType.Delete(cardtype_id);
        }
    }
}