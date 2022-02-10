namespace VangelAuto.Services.Dto
{
    using System.Collections.Generic;

    public class MakeModelDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<ModelDto> Models { get; set; }
    }
}
