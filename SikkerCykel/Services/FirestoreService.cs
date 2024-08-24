using SikkerCykel.Interfaces;
using Google.Cloud.Firestore;
using SikkerCykel.Models;
using SikkerCykel.Data;

namespace SikkerCykel.Services
{
    public class FirestoreService : IFirestoreService
    {
        private readonly FirestoreDb _firestoreDb;
        private const string _collectionName = "Bicycle";

        public FirestoreService(FirestoreDb firestoreDb)
        {
            _firestoreDb = firestoreDb;
        }

        public async Task<List<Bicycle>> GetAll()
        {
            var collection = _firestoreDb.Collection(_collectionName);
            var snapshot = await collection.GetSnapshotAsync();

            var shoeDocuments = snapshot.Documents.Select(s => s.ConvertTo<BicycleDocument>()).ToList();

            return shoeDocuments.Select(ConvertDocumentToModel).ToList();
        }

        public async Task Add(Bicycle bicycle)
        {
            var collection = _firestoreDb.Collection(_collectionName);
            var shoeDocument = ConvertModelToDocument(bicycle);

            await collection.AddAsync(shoeDocument);
        }

        // Convert Firestore document to model
        private static Bicycle ConvertDocumentToModel(BicycleDocument brandDocument)
        {
            return new Bicycle
            {
                Id = brandDocument.Id,
                Brand = brandDocument.Brand,
                Model = brandDocument.Model,
                Type = brandDocument.Type,
                Color = brandDocument.Color,
                GearCount = brandDocument.GearCount,
                Price = brandDocument.Price,
                Weight = brandDocument.Weight,
                IsElectric = brandDocument.IsElectric
            };
        }

        // Convert model to Firestore document
        private static BicycleDocument ConvertModelToDocument(Bicycle bicycle)
        {
            return new BicycleDocument
            {
                Id = bicycle.Id,
                Brand = bicycle.Brand,
                Model = bicycle.Model,
                Type = bicycle.Type,
                Color = bicycle.Color,
                GearCount = bicycle.GearCount,
                Price = bicycle.Price,
                Weight = bicycle.Weight,
                IsElectric = bicycle.IsElectric
            };
        }
    }
}
