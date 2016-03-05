namespace DAO
{
    public class ConnectionCRM : Connection.Connection
    {
        public ConnectionCRM()
            : base(System.Configuration.ConfigurationManager.ConnectionStrings["CRM"].ConnectionString)
        {
        }
    }
}