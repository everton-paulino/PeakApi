using MongoDB.Driver;
using PeakApi.Models;
using PeakApi.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeakApi.Repository
{
    public class LendingRepository : ILendingRepository
    {
        private readonly IMongoCollection<Lending> _collectionLending;
        public LendingRepository()
        {
            var client = new MongoClient(Environment.GetEnvironmentVariable("PEAK_DB_CONNECTIONSTRING"));
            var database = client.GetDatabase("DBCRUD");
            _collectionLending = database.GetCollection<Lending>("Lending");
        }
        public List<Lending> GetLending()
        {
            var lendings = _collectionLending.Find(b => b.IsActive).ToList();

            return lendings;
        }

        public Lending GetLendingToKey(string KeyLending)
        {
            var lendings = _collectionLending.Find(p => p.Key == KeyLending).FirstOrDefault();

            return lendings;
        }

        public Lending PostLending(Lending lending)
        {
            _collectionLending.InsertOne(lending);

            return lending;
        }

        public Lending UpdateLending(Lending lending)
        {
            _collectionLending.ReplaceOneAsync(c => c.Key == lending.Key, lending);

            return lending;
        }
    }
    
}
