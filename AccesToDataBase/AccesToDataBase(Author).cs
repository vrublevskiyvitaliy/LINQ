using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

using System.Data.Entity;

namespace AccesToDataBase
{
    public partial class AccesToDataBase
    {

        // Two authors are different if name and year is different
        //
        //

        public List<Author> getAllAuthors()
        {
            List<Author> list = new List<Author>();
            var searched = from c in DataBase.Authors select c;
            foreach (var current in searched)
            {
                Author author = new Author(current.ID, current.Name, current.Year);
                list.Add(author);

            }
            return list;

        }

        public List<string> getAllAuthorsString()
        {
            List<Author> list = getAllAuthors();
            List<string> result = new List<string>();
            foreach (Author current in list)
            {
                result.Add(current.Name);

            }
            return result;

        }

        public List<Author> getFilteredAuthors(Author filter)
        {
            List<Author> list = new List<Author>();

            var searched = (from c in DataBase.Authors where
                                ((filter.Name == string.Empty) || (c.Name.ToUpper().Contains(filter.Name.ToUpper()))) &&
                                ((filter.Year == 0) || (c.Year == filter.Year))
                                select c
                                ).ToList();

            foreach (var c in searched)
            {
                Author tmp = new Author(c.ID, c.Name, c.Year);
                list.Add(tmp);

            }

            return list;
        
        }


        public List<Question> getQuestionByAuthor(Author author)
        {
            List<Question> list = new List<Question>();

            var searched = (from c in DataBase.Base where c.AuthorID == author.ID select c).ToList();

            foreach (var c in searched)
            {

                Question question = new Question(
                                    c.ID,
                                    c.TypeOfQuestion.Name,
                                    c.Name,
                                    c.Answear,
                                    c.Year,
                                    c.Authors.Name,
                                    c.Difficulties.Name,
                                    c.Comment);
                list.Add(question);
            }

            return list;
        
        }

        //check by name and year
        public bool canAddAuthor(Author author)
        {
            var searched = (from c in DataBase.Authors where (c.Name == author.Name) && (c.Year == author.Year) select c).Any();

            return !searched;

        }
        //check by name and year
        public bool canChangeAuthor(Author author)
        {
            var isExistAuthor = (from c in DataBase.Authors where c.ID == author.ID select c).Any();
            if (!isExistAuthor) return false;

            return canAddAuthor(author);
        
        }
        //check is author exist and is author in Base
        public bool canDeleteAuthor(Author author)
        {
            var isIDCorrect = (from c in DataBase.Authors where c.ID == author.ID select c).Any();
            if (!isIDCorrect) return false;

            var searched = (from c in DataBase.Base where c.AuthorID == author.ID select c).Any();

            return !searched;

        }


        //Firstly check if can add
        public bool addAuthor(Author author)
        {
            if (canAddAuthor(author))
            {
                DataBase.Authors.Add(new Authors() 
                { 
                    Name = author.Name,
                    Year = author.Year
                }
                );

                DataBase.SaveChanges();

                return true;
            }
            else
                return false;
        
        
        }

        //Firstly check if can change
        public bool changeAuthor(Author author)
        {
            if (canChangeAuthor(author))
            {
                var searched = (from c in DataBase.Authors where c.ID == author.ID select c).FirstOrDefault();

                searched.Name = author.Name;
                searched.Year = author.Year;

                DataBase.SaveChanges();

                return true;
            }
            else
                return false;
        
        }
        //Firstly check if can delete
        public bool deleteAuthor(Author author)
        {
            if (canDeleteAuthor(author))
            {

                var searched = (from c in DataBase.Authors where c.ID == author.ID select c).FirstOrDefault();

                DataBase.Authors.Remove(searched);

                DataBase.SaveChanges();
                
                return true;
            }
            else
                return false;


        }


    }
}
