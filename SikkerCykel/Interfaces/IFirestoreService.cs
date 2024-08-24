using SikkerCykel.Dtos;
using SikkerCykel.Models;

namespace SikkerCykel.Interfaces
{
    public interface IFirestoreService
    {
        public Task<List<Bicycle>> GetAll();

        public Task Add(Bicycle bicycle);
    }
}
