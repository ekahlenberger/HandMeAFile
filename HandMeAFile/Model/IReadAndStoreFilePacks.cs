using System;
using System.Collections.Generic;

namespace org.ek.HandMeAFile.Model
{
    public interface IReadAndStoreFilePacks : IDisposable
    {
        event EventHandler ClipboardFilePacksUpdated;
        IEnumerable<FilePack> GetAll();
    }
}