using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblPointRule
    {
        public static List<DTO.tblPointRule> GetAll()
        {
            return DAO.tblPointRule.Get(0);
        }

        public static DTO.tblPointRule GetByID(int rule_id)
        {
            return DAO.tblPointRule.Get(rule_id).FirstOrDefault();
        }

        public static int Create(DTO.tblPointRule item)
        {
            return DAO.tblPointRule.Create(item);
        }

        public static int Delete(int rule_id)
        {
            return DAO.tblPointRule.Delete(rule_id);
        }
    }
}