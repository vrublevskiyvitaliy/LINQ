using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Question
    {
        public int ID { get; private set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public string Answear { get; set; }
        public int Year { get; set; }

        public string Author { get; set; }
        public string Difficulty { get; set; }
        public string Comment { get; set; }



        public Question()
        {

        }

        public Question(int id, string type, string name, string answear,
            int year, string author, string difficulty, string comment = null)
        {
            ID = id;
            Type = type;
            Name = name;
            Answear = answear;
            Year = year;
            Author = author;
            Difficulty = difficulty;
            Comment = String.Empty;
            if (comment != null)
                Comment = comment;

        }


        public bool Compare(Question question)
        {
            if (question.ID == ID &&
                question.Name == Name &&
                question.Type == Type &&
                question.Answear == Answear &&
                question.Author == Author &&
                question.Comment == Comment &&
                question.Difficulty == Difficulty &&
                question.Year == Year)
                return true;
            return false;

        }
    }
}
