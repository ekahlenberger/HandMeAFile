using System.Net;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Net
{
    public class TransportContextWrapper : ITransportContext
    {
        private readonly TransportContext m_context;
        public TransportContextWrapper(TransportContext context)
        {
            m_context = context;
        }

        public static implicit operator TransportContext(TransportContextWrapper wrapper)
        {
            return wrapper.m_context;
        }
        public static implicit operator TransportContextWrapper(TransportContext context)
        {
            return new TransportContextWrapper(context);
        }
    }
}