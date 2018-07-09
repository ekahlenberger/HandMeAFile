namespace org.ek.HandMeAFile.commons.IO
{
    public class GenericProgressInfo
    {
        public int CurrentIncrement { get; }
        public long CurrentValue { get; }
        public long MaxValue { get; }

        public GenericProgressInfo(int currentIncrement, long currentValue, long maxValue)
        {
            CurrentIncrement = currentIncrement;
            CurrentValue = currentValue;
            MaxValue = maxValue;
        }
    }
}