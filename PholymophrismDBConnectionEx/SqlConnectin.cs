using System;
using System.Threading;

namespace PholymophrismDBConnectionEx
{
    public class SqlConnectin : DbConnectin
    {
        private bool _isOpen;

        public SqlConnectin(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            if (!_isOpen)
                throw new InvalidOperationException("Sql Connection is not open");

            _isOpen = false;
            Console.WriteLine("Sql Connection is close");
        }

        public override void Open()
        {
            if (_isOpen)
                throw new InvalidOperationException("Sql Connection is open");

            Console.WriteLine("Sql Connection is opening");
            var t1 = DateTime.Now;

            Thread.Sleep(new TimeSpan(0, 0, 0, 16));

            if (DateTime.Now - t1 > TimeOut)
                throw new TimeoutException("Sql connection timeout");

            _isOpen = true;
            Console.WriteLine("Sql Connection is open");
        }
    }
}
