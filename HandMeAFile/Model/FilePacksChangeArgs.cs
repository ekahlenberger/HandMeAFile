using System;

namespace org.ek.HandMeAFile.Model
{
    public class FilePacksChangeArgs : EventArgs
    {
        public FilePack            ChangedPack { get; }
        public FilePacksChangeType OpType      { get; }
        
        public FilePacksChangeArgs(FilePack changedPack, FilePacksChangeType opType)
        {
            ChangedPack = changedPack;
            OpType      = opType;
        }

    }
}