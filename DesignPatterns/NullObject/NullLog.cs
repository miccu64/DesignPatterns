using DesignPatterns.NullObject.Interfaces;

namespace DesignPatterns.NullObject
{
    public class NullLog : ILog
    {
        public int RecordLimit => int.MaxValue;

        public int RecordCount { get; set; }

        public void LogInfo(string message)
        {
            RecordCount++;
        }
    }
}
