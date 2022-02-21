using APIAssignment1.DB;
using APIAssignment1.DTO;
using APIAssignment1.Entities;
using APIAssignment1.Interface;

namespace APIAssignment1.Services
{
    public class PersonService : IPersonService
    {
        private PersonContext _context;

        public PersonService(PersonContext context)
        {
            _context = context;
        }

        public void AddPerson(PersonDTO person)
        {
            _context.People.Add(new Person() { 
                FirstName = person.FirstName,
                LastName = person.LastName,
                DateOfBirth = person.DateOfBirth,
                Gender = person.Gender,
                BirthPlace = person.BirthPlace
             });

            _context.SaveChanges();
        }

        public void Initialized(){
            _context.People.AddRange(new List<Person> { 
                new Person {Id = 1, FirstName= "Truong", LastName="Nguyen", DateofBirth = new DateTime(2000,01,02), Gender = Gender.Male,BirthPlace = "bac ninh"},
               new Person {Id = 1, FirstName= "Trung Anh", LastName="Do", DateofBirth = new DateTime(1999,01,02), Gender = Gender.Male,BirthPlace = "bac kan"},
               new Person {Id = 1, FirstName= "Huong", LastName="Bui", DateofBirth = new DateTime(1998,01,02), Gender = Gender.Male,BirthPlace = "nam ninh"},
               new Person {Id = 1, FirstName= "Chien", LastName="Nguyen", DateofBirth = new DateTime(2000,01,02), Gender = Gender.Male,BirthPlace = "bac ninh"}
             });

        }

    }
}