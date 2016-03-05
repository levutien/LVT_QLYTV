using System;
using System.Collections.Generic;

namespace DAO
{
    public class tblMemberCard
    {
        public static List<DTO.tblMemberCard> Get(int card_id)
        {
            List<DTO.tblMemberCard> lsArray = new List<DTO.tblMemberCard>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Card_ID", card_id));
                System.Data.DataTable dt = conn.ExecuteNonQueryData("sp_tblMemberCard_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DTO.tblMemberCard(row)); }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(DTO.tblMemberCard item)
        {
            int result = 0;
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Card_ID", item.Card_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@CardType_ID", item.CardType_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Customer_ID", item.Customer_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@IssueDate", item.IssueDate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@IssuePlace_ID", item.IssuePlace_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@IssueBy", item.IssueBy));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ExpDate", item.ExpDate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Status_ID", item.Status_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@TotalPoint", item.TotalPoint));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@AccessCode", item.AccessCode));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@EMRCode", item.EMRCode));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@EMRPlace_ID", item.EMRPlace_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Notes", item.Notes));
                result = conn.ExecuteNonQuery("sp_tblMemberCard_Create", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }

        public static int Delete(int card_id)
        {
            int result = 0;
            List<DTO.tblMemberCard> lsArray = new List<DTO.tblMemberCard>();
            ConnectionCRM conn = null;
            try
            {
                conn = new ConnectionCRM();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Card_ID", card_id));
                result = conn.ExecuteNonQuery("sp_tblMemberCard_Delete", lsInput);
            }
            catch (Exception ex) { result = -1; }
            finally { conn.Close(); }
            return result;
        }
    }
}