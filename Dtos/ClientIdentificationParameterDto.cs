using SherlockAPI.Models;

namespace SherlockAPI.Dtos
{
    public class ClientIdentificationParameterDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }

        public static ClientIdentificationParameterDto FromEntity(ClientIdentificationParameter cip)
        {
            return new ClientIdentificationParameterDto()
            {
                Id = cip.Id,
                Name = cip.Name,
                IsRequired = cip.IsRequired,
                DisplayOrder = cip.DisplayOrder
            };
        }
    }
}
