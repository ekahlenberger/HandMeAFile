using System;

namespace org.ek.HandMeAFile.commons.UI.MVVM.CommandCreation
{
    public static class ProgressExtensions
    {
        public static void Report<TUiProgressInfo>(this IProgress<ProgressNotification<TUiProgressInfo>> progress, TUiProgressInfo progressInfo)
        {
            progress?.Report(new ProgressNotification<TUiProgressInfo>(progressInfo));
        }
        public static void Report<TUiProgressInfo>(this IProgress<ProgressNotification<TUiProgressInfo>> progress, TUiProgressInfo progressInfo, int current, int max)
        {
            progress?.Report(new ProgressNotification<TUiProgressInfo>(progressInfo,current, max));
        }
    }
}