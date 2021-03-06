using System.Runtime.Serialization;

namespace TextService.DTO
{
    [DataContract]
    public class Country
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
