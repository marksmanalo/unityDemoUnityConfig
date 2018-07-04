namespace UnityDemoWithConfig
{
    public class SqlDataAccess : IDbAccess
    {
        public string GetConnection()
        {
            return "new connection string";
        }
    }
}
