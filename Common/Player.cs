using System;

namespace Common
{
    public class Player : Person
    {
        public Player()
        {
        }

        public Player(int id, string name, int year)
            : base(id, name, year)
        {

        }

        public Player(Person person) : base(person.ID, person.Name, person.Year)
        {

            

        }
    }
}
