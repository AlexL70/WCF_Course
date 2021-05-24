using System.Runtime.Serialization;

namespace TextService.DTO
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Sid { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public int M1 { get; set; }
        [DataMember]
        public int M2 { get; set; }
        [DataMember]
        public int M3 { get; set; }
    }
}
