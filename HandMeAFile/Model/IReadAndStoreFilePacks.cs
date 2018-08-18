using System;
using System.Collections.Generic;

namespace org.ek.HandMeAFile.Model
{
    public interface IReadAndStoreFilePacks : IDisposable
    {
        event EventHandler<FilePacksChangeArgs> ClipboardFilePacksUpdated;
        IEnumerable<FilePack> GetTop(int count);
        IEnumerable<FilePack> GetAll();
        void Init(FilePack[] initialPacks = null);
        void Remove(FilePack filePack);
    }
}