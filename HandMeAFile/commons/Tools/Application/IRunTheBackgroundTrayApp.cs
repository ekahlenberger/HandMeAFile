namespace org.ek.HandMeAFile.commons.Tools.Application
{
    public interface IRunTheBackgroundTrayApp
    {
        int SleepTime { get; }
        void Run();
    }
}