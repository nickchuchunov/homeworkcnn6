using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public class ServicesPerson : IRepositoryPersen<Person>
    {
        public Person GetPersonOfId(int Id, List<Person> _person) //  получение человека по идентификатору
        {
            int i = Id; return _person[i];
        }

        public List<Person> PaginationListPerson(List<Person> _person) //  получение списка людей с пагинацией
        {
            return _person;
        }

        public List<Person> RemovalPerson(List<Person> _person, int Id) // Удаление персоны
        {
            for (int i=0; i< _person.Count(); i++) { while (_person[i].Id == Id) { _person.Remove(_person[i]);     } }

            return _person;
        }

        public List<Person> SearhPersonOfFirstName(string FirstName, List<Person> _person) //  поиск человека по имени
        {
            List<Person> People = new List<Person>();
            foreach (Person people in _person) { while (people.FirstName == FirstName) { People.Add(people); } }


            return People;
        }

        public List<Person> UpdatePersonList(List<Person> _person, Person _pipel) //Обновление персоны в коллекции
        {
            for (int i = 0; i < _person.Count; i++)
            {
                while (_person[i].Id == _pipel.Id)
                {

                    _person[i].FirstName = _pipel.FirstName; _person[i].LastName = _pipel.LastName; _person[i].Email = _pipel.Email; _person[i].Company = _pipel.Company; _person[i].Age = _pipel.Age;
                }
            }
            return _person;


      
        }


        public List<Person> AddPersonOfList(List<Person> _person, Person _pipel) { _person.Add(_pipel); return _person; }



    }






}
