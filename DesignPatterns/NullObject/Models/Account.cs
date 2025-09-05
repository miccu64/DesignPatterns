using DesignPatterns.NullObject.Interfaces;
using System;

namespace DesignPatterns.NullObject.Models
{
    public class Account
    {
        private readonly ILog _log;

        public Account(ILog log)
        {
            _log = log;
        }

        public void SomeOperation()
        {
            int c = _log.RecordCount;
            _log.LogInfo("Performing an operation");

            if (c + 1 != _log.RecordCount)
                throw new Exception();
            if (_log.RecordCount >= _log.RecordLimit)
                throw new Exception();
        }
    }
}
