namespace SikkerCykel.Models
{
    public class Bicycle //TODO: Talk with Nina about this model!
    {
        public string Id { get; set; } = string.Empty;
        public string Brand { get; set; } // Mærket af cyklen
        public string? Model { get; set; } // Modellens navn
        public string? Type { get; set; } // Typen af cykel (f.eks. Mountain Bike, Road Bike, etc.)
        public string? Color { get; set; } // Farven på cyklen
        public int? GearCount { get; set; } // Antal gear på cyklen
        public double? Price { get; set; } // Prisen på cyklen
        public double? Weight { get; set; } // Vægten af cyklen i kilogram
        public bool? IsElectric { get; set; } // Om cyklen er elektrisk eller ej
    }
}
