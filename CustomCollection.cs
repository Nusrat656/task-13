using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public class CustomCollection
    {
        public List<Person> persons;

        public CustomCollection()
        {
            persons = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public Person FindEmployeeById(int id)
        {
            foreach (var person in persons)
            {
                if (person is Employee && ((Employee)person).Id == id)
                {
                    return person;
                }
            }
            return null;
        }
        public void DisplayAllEmployees()
        {
            foreach (var person in persons)
            {
                if (person is Employee)
                {
                    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Surname: {person.Surname}, Age: {person.Age}, Salary: {((Employee)person).Salary}");
                }
            }
        }
    }
}
