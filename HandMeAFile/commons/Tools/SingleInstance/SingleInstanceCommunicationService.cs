using System;
using System.ServiceModel;

namespace org.ek.HandMeAFile.commons.Tools.SingleInstance
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class SingleInstanceCommunicationService : IRunOnceService
    {
        public void SecondInstanceRun(string[] args)
        {
            OnSecondInstanceRunCalled(args);
        }

        public event EventHandler<SecondInstanceEventArgs> SecondInstanceRunCalled;

        protected virtual void OnSecondInstanceRunCalled(string[] args)
        {
            SecondInstanceRunCalled?.Invoke(this, new SecondInstanceEventArgs(args));
        }
    }
}