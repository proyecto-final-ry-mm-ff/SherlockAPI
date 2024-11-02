namespace SherlockAPI.Models
{
    public class ClientIdentificationParameters
    {
        // public DateOnly Date { get; set; }

        // public int TemperatureC { get; set; }

        // public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        // public string? Summary { get; set; }

        //  { parameterId= 1, name= "Nombre", isRequired= true, displayOrder= 1 },

        public string? Id { get; set; }
        public string? Name { get; set; }

        public bool? isRequired { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
