using ContractMeneger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    [Route("api/HomeController")]
    [ApiController]
    public class HomeController : Controller
    {

        private ServicesPerson _ServicesPerson;
        private ListPersonRepository _ListPersonRepository;

        HomeController(ServicesPerson _ServicesPerson, ListPersonRepository _ListPersonRepository) 
        {

            this._ServicesPerson = _ServicesPerson;
            this._ListPersonRepository = _ListPersonRepository;


        }

        //GET /persons/{id}
        [HttpGet("/persons/{id}")]

        public Person ControllerGetPersonOfId ([FromRoute] int Id ) { return _ServicesPerson.GetPersonOfId(Id, _ListPersonRepository.Datebase);       }//  получение человека по идентификатору
        
        [HttpGet("/persons/search?FirstName={FirstName} ")]
        public List<Person> ControllerSearhPersonOfFirstName([FromRoute] string FirstName) { return _ServicesPerson.SearhPersonOfFirstName(FirstName, _ListPersonRepository.Datebase); } //  поиск человека по имени
     
        [HttpGet("/persons/?skip={5}&take={10}")]
        public List<Person> ControllerPaginationListPerson() { return _ServicesPerson.PaginationListPerson( _ListPersonRepository.Datebase); }  //  получение списка людей с пагинацией
    
        [HttpPut("/persons")]
        public List<Person> ControllerUpdatePersonList([FromRoute] Person person) { return _ServicesPerson.UpdatePersonList(_ListPersonRepository.Datebase, person); }      //Обновление персоны в коллекции
                                                                                                                                                                 
        [HttpDelete("/persons/{Id}")]
        public List<Person> ControllerRemovalPerson([FromRoute] int Id) { return _ServicesPerson.RemovalPerson(_ListPersonRepository.Datebase, Id); }   // Удаление персоны
                                                                                                                                           
        [HttpPost("/persons")]
        public List<Person> ControllerAddPersonOfList([FromRoute] Person person) { return _ServicesPerson.AddPersonOfList(_ListPersonRepository.Datebase, person); }     //  добавление новой персоны в коллекцию 

    }
}
