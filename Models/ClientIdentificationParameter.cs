namespace SherlockAPI.Models
{
    public class ClientIdentificationParameter
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }
    }
}
