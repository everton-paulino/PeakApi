using MongoDB.Driver;
using PeakApi.Models;
using PeakApi.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeakApi.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IMongoCollection<Person> _collectionPerson;
        public PersonRepository()
        {
            var client = new MongoClient(Environment.GetEnvironmentVariable("PEAK_DB_CONNECTIONSTRING"));
            var database = client.GetDatabase("DBCRUD");
            _collectionPerson = database.GetCollection<Person>("Person");
        }
        public List<Person> GetPeople()
        {
            var people = _collectionPerson.Find(b => b.IsActive).ToList();

            return people;
        }

        public Person GetPersonToKey(string KeyPerson)
        {
            var person = _collectionPerson.Find(p => p.Key == KeyPerson).FirstOrDefault();

            return person;
        }

        public Person PostPerson(Person person)
        {
            _collectionPerson.InsertOne(person);

            return person;
        }

        public Person UpdatePerson(Person person)
        {
            _collectionPerson.ReplaceOneAsync(c => c.Key == person.Key, person);

            return person;
        }
    }
}

