﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using JetBrains.Annotations;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows;
using org.ek.HandMeAFile.commons.Extensions;
using org.ek.HandMeAFile.commons.Tools;

namespace org.ek.HandMeAFile.Model
{
    public class ClipboardFilesRepository : IReadAndStoreFilePacks
    {
        private readonly INotifyOfClipboardUpdates           m_clipUpdater;
        private readonly IClipboard                          m_clipboard;
        private readonly ConcurrentDictionary<FilePack, int> m_packs = new ConcurrentDictionary<FilePack, int>();
        public event EventHandler<FilePacksChangeArgs>       ClipboardFilePacksUpdated;

        public ClipboardFilesRepository([NotNull] INotifyOfClipboardUpdates clipUpdater, [NotNull] IClipboard clipboard)
        {
            Debug.Assert(clipUpdater != null, nameof(clipUpdater) + " != null");
            Debug.Assert(clipboard   != null, nameof(clipboard)   + " != null");

            m_clipUpdater = clipUpdater;
            m_clipboard   = clipboard;
        }

        public void Init(FilePack[] initialPacks = null)
        {
            if (initialPacks != null)
            {
                foreach (FilePack initialPack in initialPacks)
                    m_packs.AddOrUpdate(initialPack, initialPack.ClipboardCount);
            }

            m_clipUpdater.ClipboardUpdate += ClipboardChanged;
        }

        public void Remove(FilePack filePack)
        {
            m_packs.TryRemove(filePack, out _);
            ClipboardFilePacksUpdated?.Invoke(this, new FilePacksChangeArgs(filePack,FilePacksChangeType.Deleted));
        }

        private void ClipboardChanged(object sender, EventArgs e)
        {
            if (!m_clipboard.ContainsFileDropList()) return;

            FilePack pack = new FilePack(m_clipboard.GetFileDropListPaths());
            m_packs.AddOrUpdate(pack, 1, (existingPack, existingCount) => ++existingCount);
            ClipboardFilePacksUpdated?.Invoke(this, new FilePacksChangeArgs(pack,FilePacksChangeType.Added));
        }

        public IEnumerable<FilePack> GetTop(int count)
        {
            if (count <= 0) throw new ArgumentOutOfRangeException(nameof(count));
            return m_packs.OrderBy(kvp => kvp.Value).Where(kvp => kvp.Key.CommonAncestor != null).Take(count).Select(SetCount);
        }

        public IEnumerable<FilePack> GetAll() => m_packs.Select(SetCount);

        private FilePack SetCount(KeyValuePair<FilePack, int> kvp) => kvp.Key.SetCount(kvp.Value);

        public void Dispose()
        {
            m_clipUpdater?.Dispose();
        }
    }
}