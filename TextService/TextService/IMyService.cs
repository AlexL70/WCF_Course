using System.ServiceModel;

namespace TextService
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string GetData();

        [OperationContract]
        string GetMessage(string Name);

        [OperationContract]
        string GetResult(int Sid, string SName, int M1, int M2, int M3);

        [OperationContract]
        int GetMax(int[] arr);

        [OperationContract]
        int[] GetSorted(int[] arr);
    }
}
