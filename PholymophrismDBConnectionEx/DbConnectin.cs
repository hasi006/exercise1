using System;

namespace PholymophrismDBConnectionEx
{
    public abstract class DbConnectin
    {
        private readonly string _connectionString;
        
        public DbConnectin(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("connection string is required");

            this._connectionString = connectionString;
        }

        public TimeSpan TimeOut { get; set; } = new TimeSpan(0, 0, 15);//default time out set to 15 seconds

        public abstract void Open();

        public abstract void Close();
    }
}
