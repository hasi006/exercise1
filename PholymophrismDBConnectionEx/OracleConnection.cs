using System;
using System.Threading;

namespace PholymophrismDBConnectionEx
{
    public class OracleConnection : DbConnectin
    {
        private bool _isOpen;

        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            if (!_isOpen)
                throw new InvalidOperationException("Oracle Connection is not open");

            _isOpen = false;
            Console.WriteLine("Oracle Connection is close");
        }

        public override void Open()
        {
            if (_isOpen)
                throw new InvalidOperationException("Oracle Connection is open");

            Console.WriteLine("Oracle Connection is opening");
            var t1 = DateTime.Now;

            Thread.Sleep(new TimeSpan(0, 0, 0, 2));

            if (DateTime.Now - t1 > TimeOut)
                throw new TimeoutException("Oracle connection timeout");

            _isOpen = true;
            Console.WriteLine("Oracle Connection is open");

        }
    }
}
