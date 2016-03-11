using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class tblMemberCard
    {
        public static List<DTO.tblMemberCard> GetAll()
        {
            return DAO.tblMemberCard.Get(0);
        }

        public static DTO.tblMemberCard GetByID(int card_id)
        {
            return DAO.tblMemberCard.Get(card_id).FirstOrDefault();
        }

        public static int Create(DTO.tblMemberCard item)
        {
            return DAO.tblMemberCard.Create(item);
        }

        public static int Delete(int card_id)
        {
            return DAO.tblMemberCard.Delete(card_id);
        }

        public static System.Data.DataTable Login(int card_id, string email, string accessCode)
        {
            return DAO.tblMemberCard.Login(card_id, email, accessCode);
        }

        public static bool ChangePassword(int card_id, string accessCodeOld, string accessCodeNew)
        {
            return DAO.tblMemberCard.ChangePassword(card_id, accessCodeOld, accessCodeNew);
        }
    }
}