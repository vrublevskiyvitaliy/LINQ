using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Person
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Person()
        {

        }

        public Person(int id, string name, int year)
        {
            ID = id;
            Name = name;
            Year = year;

        }

        public bool Compare(Person person)
        {
            return (person.ID == ID) && (person.Name == Name) && (person.Year == Year);


        }
    }
}
