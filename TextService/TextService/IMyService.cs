using System.ServiceModel;

namespace TextService
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string GetData();
    }
}
