namespace org.ek.HandMeAFile.commons.UI.MVVM.CommandCreation
{
    public class ProgressNotification<TUiInfo>
    {
        public int     Current       { get; }
        public int     Max           { get; }
        public TUiInfo Label         { get; }
        public bool    Indeterminate { get; }

        public ProgressNotification(TUiInfo label)
        {
            Label         = label;
            Indeterminate = true;
        }

        public ProgressNotification(TUiInfo label, int current, int max)
        {
            Label   = label;
            Current = current;
            Max     = max;
        }
    }
}