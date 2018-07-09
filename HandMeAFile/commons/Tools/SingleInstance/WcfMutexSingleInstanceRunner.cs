using System;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace org.ek.HandMeAFile.commons.Tools.SingleInstance
{
    public class WcfMutexSingleInstanceRunner : IRunTheAppOnce, IDisposable
    {
        private readonly string m_uniqueIdentifier;
        private Mutex m_mutex;
        private ServiceHost m_serviceHost;

        public event EventHandler<SecondInstanceEventArgs> SecondInstanceStarted;

        public WcfMutexSingleInstanceRunner(string uniqueIdentifier)
        {
            m_uniqueIdentifier = uniqueIdentifier;
        }

        public bool Run(StartupEventArgs args)
        {
            m_mutex = new Mutex(true, m_uniqueIdentifier);
            if (m_mutex.WaitOne(10))
            {
                SingleInstanceCommunicationService singleInstanceCommunicationService = new SingleInstanceCommunicationService();
                m_serviceHost = new ServiceHost(singleInstanceCommunicationService, new Uri($"net.pipe://localhost/{m_uniqueIdentifier}"));
                m_serviceHost.AddServiceEndpoint(typeof(IRunOnceService), new NetNamedPipeBinding(), "singleInstService");
                m_serviceHost.Open();
                singleInstanceCommunicationService.SecondInstanceRunCalled += (sender, arg) => OnSecondInstanceStarted(new SecondInstanceEventArgs(args.Args));
                return true;
            }

            ChannelFactory<IRunOnceService> pipeFactory = new ChannelFactory<IRunOnceService>(new NetNamedPipeBinding(),
                                                                                              new EndpointAddress($"net.pipe://localhost/{m_uniqueIdentifier}/singleInstService"));
            IRunOnceService runOnceService = pipeFactory.CreateChannel();
            runOnceService.SecondInstanceRun(args.Args);
            return false;
        }
        protected virtual void OnSecondInstanceStarted(SecondInstanceEventArgs e)
        {
            Task.Run(() => SecondInstanceStarted?.Invoke(this, e));
        }
        /// <summary>Führt anwendungsspezifische Aufgaben durch, die mit der Freigabe, der Zurückgabe oder dem Zurücksetzen von nicht verwalteten Ressourcen zusammenhängen.</summary>
        public void Dispose()
        {
            m_mutex?.Dispose();
            ((IDisposable)m_serviceHost)?.Dispose();
        }
    }
}