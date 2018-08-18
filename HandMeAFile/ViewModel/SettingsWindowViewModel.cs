using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using org.ek.HandMeAFile.commons.UI.MVVM;
using org.ek.HandMeAFile.commons.UI.MVVM.CommandCreation;
using org.ek.HandMeAFile.Model;
using System.Linq;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Threading;
using org.ek.HandMeAFile.commons.Tools;

namespace org.ek.HandMeAFile.ViewModel
{
    public class SettingsWindowViewModel : ISettingsWindowViewModel
    {
        [NotNull] private readonly IReadAndStoreFilePacks m_filePacksRepository;
        [NotNull] private readonly IProvideService<ICreateCommands<ProgressInfo>> m_commandCreatorProvider;
        [NotNull] private readonly IDispatcher m_uiDispatcher;

        private ICreateCommands<ProgressInfo> m_commandCreator;
        public ICreateCommands<ProgressInfo> CommandCreator => m_commandCreator ?? (m_commandCreator = m_commandCreatorProvider.Get());

        private IExecCommand m_loadFilePacks;
        private IExecCommand m_deleteFilePack;
        private string m_errorMessage;
        public IExecCommand LoadFilePacks => m_loadFilePacks ?? (m_loadFilePacks = CommandCreator.CreateInitial(LoadFilePacksBg, ProcessLoadedFilePacks));
        private IExecCommand DeleteFilePack => m_deleteFilePack ?? (m_deleteFilePack = CommandCreator.CreateProcessing<FilePackViewModel,FilePackViewModel>(DeleteFilePackBg, ProcessFilePackDeleted));

        public ObservableCollection<FilePackViewModel> FilePacks { get; set; } = new ObservableCollection<FilePackViewModel>();
        public IProgress<ProgressNotification<ProgressInfo>> Progress { get; }
        public string ErrorMessage
        {
            get => m_errorMessage;
            private set
            {
                if (!string.Equals(value, m_errorMessage, StringComparison.OrdinalIgnoreCase))
                    m_errorMessage = value;
                OnPropertyChanged();
            }
        }

        public SettingsWindowViewModel([NotNull] IReadAndStoreFilePacks filePacksRepository, [NotNull] IProvideService<ICreateCommands<ProgressInfo>> commandCreatorProvider,
                                       [NotNull] IDispatcher uiDispatcher)
        {
            Debug.Assert(filePacksRepository != null, nameof(filePacksRepository) + " != null");
            Debug.Assert(commandCreatorProvider != null, nameof(commandCreatorProvider) + " != null");
            Debug.Assert(uiDispatcher != null, nameof(uiDispatcher) + " != null");

            m_filePacksRepository = filePacksRepository;
            m_commandCreatorProvider = commandCreatorProvider;
            m_uiDispatcher = uiDispatcher;
            Progress = new Progress<ProgressNotification<ProgressInfo>>(ProgressHandler);
            m_filePacksRepository.ClipboardFilePacksUpdated += FilePacksChanged;
        }

        private void FilePacksChanged(object sender, EventArgs e)
        {
            if (!m_uiDispatcher.CheckAccess())
            {
                m_uiDispatcher.Invoke(() => FilePacksChanged(sender, e));
                return;
            }
            LoadFilePacks.Execute();
        }

        private void ProgressHandler(ProgressNotification<ProgressInfo> arg)
        {
            // no progress handling yet
        }

        private void ProcessLoadedFilePacks(FilePackViewModel[] loadedFilePacks)
        {
            FilePacks.Clear();
            foreach (FilePackViewModel filePack in loadedFilePacks)
                FilePacks.Add(filePack);
        }
        private FilePackViewModel[] LoadFilePacksBg(IProgress<ProgressNotification<ProgressInfo>> progress)
        {
            progress.Report(ProgressInfo.LoadingFilePacks);
            return m_filePacksRepository.GetAll().Select(pack => new FilePackViewModel
            {
                    Label = pack.CommonAncestor,
                    Files = new ObservableCollection<string>(pack.OrderBy(p => p).Select(p => p.ToString())),
                    Tag = pack,
                    DeleteFilePack = DeleteFilePack
            }).OrderBy(pack => pack.Label).ToArray();
        }

        private void ProcessFilePackDeleted(FilePackViewModel deletedPack)
        {
            FilePacks.Remove(deletedPack);
        }
        private FilePackViewModel DeleteFilePackBg(FilePackViewModel dfpvm, IProgress<ProgressNotification<ProgressInfo>> progress)
        {
            progress.Report(ProgressInfo.DeletingFilePack);
            m_filePacksRepository.Remove((FilePack)dfpvm.Tag);
            return dfpvm;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void ExceptionHandler(Exception ex)
        {
            m_errorMessage = ex.Message;
        }
    }
}