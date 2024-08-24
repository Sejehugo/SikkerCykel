using Google.Cloud.Firestore;

namespace SikkerCykel.Data
{
    [FirestoreData]
    public class BicycleDocument
    {
        [FirestoreDocumentId]
        public required string Id { get; set; }

        [FirestoreProperty]
        public string Brand { get; set; } // Mærket af cyklen

        [FirestoreProperty]
        public string? Model { get; set; } // Modellens navn

        [FirestoreProperty]
        public string? Type { get; set; } // Typen af cykel (f.eks. Mountain Bike, Road Bike, etc.)

        [FirestoreProperty]
        public string? Color { get; set; } // Farven på cyklen

        [FirestoreProperty]
        public int? GearCount { get; set; } // Antal gear på cyklen

        [FirestoreProperty]
        public double? Price { get; set; } // Prisen på cyklen

        [FirestoreProperty]
        public double? Weight { get; set; } // Vægten af cyklen i kilogram

        [FirestoreProperty]
        public bool? IsElectric { get; set; } // Om cyklen er elektrisk eller ej
    }
}
