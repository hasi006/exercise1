using System;

namespace PholymophrismDBConnectionEx
{
    public abstract class DBConnection
    {
        private readonly string _connectionString;

        public DBConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("Connection string is required");

            this._connectionString = connectionString;
        }

        public TimeSpan TimeOut { get; set; } = new TimeSpan(0, 0, 15);//set default time stamp to 15 seconds

        public abstract void Open();
        public abstract void Close();
    }
}
