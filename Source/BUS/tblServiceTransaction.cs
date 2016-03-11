using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class tblServiceTransaction
    {
        public static List<DTO.tblServiceTransactionView> GetView(int card_id)
        {
            return DAO.tblServiceTransaction.GetView(card_id);
        }

        public static List<DTO.tblServiceTransaction> GetAll()
        {
            return DAO.tblServiceTransaction.Get();
        }

        public static DTO.tblServiceTransaction GetByID()
        {
            return DAO.tblServiceTransaction.Get().FirstOrDefault();
        }

        public static int Create(DTO.tblServiceTransaction item)
        {
            return DAO.tblServiceTransaction.Create(item);
        }

        public static int Delete()
        {
            return DAO.tblServiceTransaction.Delete();
        }
    }
}
