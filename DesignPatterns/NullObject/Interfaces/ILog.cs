namespace DesignPatterns.NullObject.Interfaces
{
    public interface ILog
    {
        int RecordLimit { get; }
        int RecordCount { get; set; }
        void LogInfo(string message);
    }
}
