using System;

namespace Common
{
    public class Author : Person
    {
        public Author()
        {


        }
        public Author(int id, string name, int year)
            : base(id, name, year)
        {


        }

        public Author(Person person)
            : base(person.ID, person.Name, person.Year)
        { 
        
        }


    }
}
