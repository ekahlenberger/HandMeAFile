using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using org.ek.HandMeAFile.commons.Tools;

namespace org.ek.HandMeAFile.Model
{
    public class ClipboardFilesRepository : IReadAndStoreFilePacks
    {
        private readonly INotifyOfClipboardUpdates m_clipUpdater;
        private readonly ConcurrentDictionary<FilePack, int> m_packs = new ConcurrentDictionary<FilePack, int>();
        public event EventHandler ClipboardFilePacksUpdated;

        public ClipboardFilesRepository(INotifyOfClipboardUpdates clipUpdater)
        {
            m_clipUpdater = clipUpdater;
            m_clipUpdater.ClipboardUpdate += ClipboardChanged;
        }

        private void ClipboardChanged(object sender, EventArgs e)
        {
            if (Clipboard.ContainsFileDropList())
            {
                FilePack pack = new FilePack(Clipboard.GetFileDropList().Cast<string>());
                m_packs.AddOrUpdate(pack, 1, (existingPack, exstingCount) => ++exstingCount);
                ClipboardFilePacksUpdated?.Invoke(this, EventArgs.Empty);
            }
        }

        public IEnumerable<FilePack> GetAll()
        {
            return m_packs.OrderBy(kvp => kvp.Value).Take(10).Select(kvp => kvp.Key);
        }

        /// <summary>
        ///   Führt anwendungsspezifische Aufgaben durch, die mit der Freigabe, der Zurückgabe oder dem Zurücksetzen von nicht verwalteten Ressourcen zusammenhängen.
        /// </summary>
        public void Dispose()
        {
            m_clipUpdater?.Dispose();
        }
    }
}