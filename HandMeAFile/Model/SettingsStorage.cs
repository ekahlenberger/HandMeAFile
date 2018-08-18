using System;
using System.Diagnostics;
using System.Linq;
using JetBrains.Annotations;
using org.ek.HandMeAFile.commons.Tools;

namespace org.ek.HandMeAFile.Model
{
    public class SettingsStorage : IStoreSettings
    {
        private readonly IReadAndStoreFilePacks m_filePacksRepository;
        private readonly ISerialize<FilePack> m_packsSerializer;

        public SettingsStorage([NotNull] IReadAndStoreFilePacks filePacksRepository, [NotNull] ISerialize<FilePack> packsSerializer)
        {
            Debug.Assert(filePacksRepository != null, nameof(filePacksRepository) + " != null");
            Debug.Assert(packsSerializer != null, nameof(packsSerializer) + " != null");

            m_filePacksRepository = filePacksRepository;
            m_packsSerializer = packsSerializer;
            m_filePacksRepository.ClipboardFilePacksUpdated += FilePacksRepoChanged;
        }

        private void FilePacksRepoChanged(object sender, EventArgs e)
        {
            FilePacks = m_filePacksRepository.GetAll().ToArray();
        }

        public FilePack[] FilePacks
        {
            get => m_packsSerializer.Deserialize(Properties.Settings.Default.FilePacks).ToArray();
            set
            {
                Properties.Settings.Default.FilePacks = m_packsSerializer.Serialize(value);
                Properties.Settings.Default.Save();
            }
        }
    }
}