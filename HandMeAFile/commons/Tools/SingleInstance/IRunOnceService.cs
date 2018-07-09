using System;
using System.ServiceModel;

namespace org.ek.HandMeAFile.commons.Tools.SingleInstance
{
    [ServiceContract]
    public interface IRunOnceService
    {
        event EventHandler<SecondInstanceEventArgs> SecondInstanceRunCalled;
        [OperationContract(IsOneWay = true)]
        void SecondInstanceRun(string[] args);
    }
}