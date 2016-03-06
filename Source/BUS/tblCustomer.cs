using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblCustomer
    {
        public static List<DTO.tblCustomer> GetAll()
        {
            return DAO.tblCustomer.Get(0);
        }

        public static DTO.tblCustomer GetByID(int customer_id)
        {
            return DAO.tblCustomer.Get(customer_id).FirstOrDefault();
        }

        public static int Create(DTO.tblCustomer item)
        {
            return DAO.tblCustomer.Create(item);
        }

        public static int Delete(int customer_id)
        {
            return DAO.tblCustomer.Delete(customer_id);
        }
    }
}