using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public interface IRepositoryPersen <T>
    {
        public  T GetPersonOfId(int Id, List<T> _person); //  получение человека по идентификатору
        public List<T> SearhPersonOfFirstName(string FirstName, List<T> _person);  //  поиск человека по имени
        public List<T> PaginationListPerson(List<T> _person) ; //  получение списка людей с пагинацией
        public List<T> UpdatePersonList(List<T> _person, T _pipel); //Обновление персоны в коллекции
        public List<T> RemovalPerson(List<T> _person, int Id); // Удаление персоны
        public List<T> AddPersonOfList(List<T> _person, T _pipel);  //  добавление новой персоны в коллекцию 
    }
}
