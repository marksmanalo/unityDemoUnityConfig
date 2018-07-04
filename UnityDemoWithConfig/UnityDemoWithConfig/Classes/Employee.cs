namespace UnityDemoWithConfig
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        private readonly IDbAccess _dbAccess;

        public Employee(IDbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }

        public string ShowDatabaseConnection()
        {
            return _dbAccess.GetConnection();
        }
    }
}
