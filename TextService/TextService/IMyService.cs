using System.Collections.Generic;
using System.ServiceModel;
using TextService.DTO;

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
        string GetResult(Student student);
        
        [OperationContract]
        Student GetTopper(IEnumerable<Student> students);

        [OperationContract]
        int GetMax(int[] arr);

        [OperationContract]
        int[] GetSorted(int[] arr);

        [OperationContract]
        IEnumerable<Country> GetAllCountries();
    }
}
