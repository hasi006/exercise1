using System;

namespace PholymophrismDBConnectionEx
{
    public class DbCommand
    {
        private readonly DbConnectin _dbConnection;
        private readonly string _dbcommand;

        public DbCommand(DbConnectin connection,string dbcommand)
        {
            if (connection == null)
                throw new ArgumentNullException("db connection");
            if(string.IsNullOrEmpty(dbcommand))
                throw new ArgumentNullException("invalid db command");

            this._dbConnection = connection;
            this._dbcommand = dbcommand;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Command is Execting");
            _dbConnection.Close();
        }
    }
}
