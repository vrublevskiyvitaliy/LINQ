using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeOfQuestion
    {
        public int ID { get; private set; }

        public string Name { get; set; }

        public TypeOfQuestion()
        { 
        
        }

        public TypeOfQuestion(int id, string name)
        {
            ID = id;
            Name = name;
        }


        public bool compare(TypeOfQuestion type)
        {
            if (ID == type.ID && Name == type.Name)
                return true;
            else
                return false;

        }
    }

}
