using System;

namespace org.ek.HandMeAFile.Model
{
    public interface IReadAndStoreFilePacks : IDisposable
    {
        event EventHandler ClipboardFilePacksUpdated;
        FilePack[] GetTop(int count);
        FilePack[] GetAll();
        void Init(FilePack[] initialPacks = null);
    }
}