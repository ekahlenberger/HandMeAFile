using System;

namespace org.ek.HandMeAFile.commons.Tools
{
    public class ServiceProvider<TService> : IProvideService<TService>
    {
        private TService m_service;
        public event EventHandler<TService> ServiceSet;

        public TService Get()
        {
            if (m_service == null) throw new InvalidOperationException($"Missing service of type {typeof(TService)} in ServiceProvider");
            return m_service;
        }

        public void Set(TService service)
        {
            m_service = service;
            if (service !=  null)
                ServiceSet?.Invoke(this, service);
        }
    }
}