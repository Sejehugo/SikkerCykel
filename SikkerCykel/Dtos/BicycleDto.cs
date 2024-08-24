using System.ComponentModel.DataAnnotations;

namespace SikkerCykel.Dtos
{
    public class BicycleDto
    {
        [Required]
        public string Brand { get; set; } // Mærket af cyklen

        [Required]
        public string? Model { get; set; } // Modellens navn

        [Required]
        public string? Type { get; set; } // Typen af cykel (f.eks. Mountain Bike, Road Bike, etc.)

        [Required]
        public string? Color { get; set; } // Farven på cyklen

        [Required]
        public int? GearCount { get; set; } // Antal gear på cyklen

        [Required]
        public decimal? Price { get; set; } // Prisen på cyklen

        [Required]
        public double? Weight { get; set; } // Vægten af cyklen i kilogram

        [Required]
        public bool? IsElectric { get; set; } // Om cyklen er elektrisk eller ej
    }
}
