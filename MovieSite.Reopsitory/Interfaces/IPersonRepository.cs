using MovieSite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieSite.Reopsitory.Interfaces
{
   public interface IPersonRepository
    {
        void AddPerson(Person person);

        void EditPerson(Person person);

        void DeletePerson(Person personId);

        Person GetActorById(int id);

        IEnumerable<Person> GetAllPepole();
    }
}
