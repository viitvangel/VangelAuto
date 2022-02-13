namespace VangelAuto.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CarModel : IDbEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string ModelName { get; set; }

        [Required]
        [MaxLength(100)]
        public string MakeName { get; set; }
    }
}
