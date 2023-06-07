using PeakApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeakApi.Repository.Interface
{
    public interface IPersonRepository
    {
        List<Person> GetPeople();
        Person GetPersonToKey(string KeyPerson);
        Person PostPerson(Person PostPerson);
        Person UpdatePerson(Person UpdatePerson);
    }
}
