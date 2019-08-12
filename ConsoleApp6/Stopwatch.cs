using System;

namespace ConsoleApp6
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isStarted;

        public void Start()
        {
            if (_isStarted)
                throw new InvalidOperationException("Please stop before start");

            _startTime = DateTime.Now;
            _isStarted = true;
        }

        public TimeSpan Stop()
        {
            if (!_isStarted)
                throw new InvalidOperationException("Please start");

            _endTime = DateTime.Now;
            _isStarted = false;

            return Duration();
        }

        private TimeSpan Duration()
        {
            var duration = _endTime - _startTime;
            return duration;
        }
    }
}
