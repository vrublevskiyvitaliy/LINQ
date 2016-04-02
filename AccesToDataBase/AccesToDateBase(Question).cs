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
        //check  by Name and type
        //in each type can be only one unique name question

        public bool canAddQuestion(Question question)
        {
            var searched = (from c in DataBase.Base where (c.Name == question.Name) && (c.TypeOfQuestion.Name == question.Type) select c).Any();


            return !searched;

        }

        //return 0 if nothing was found
        public int getAuthorIDByName(string name)
        {

            var searched = from c in DataBase.Authors where c.Name == name select c.ID;

            if (searched == null )

                return NothingWasFound;
            else
                return (searched.ToArray())[0];


        }
        //return 0 if nothing was found
        public int getDifficultiesIDByName(string name)
        {
            var searched = from c in DataBase.Difficulties where c.Name == name select c.ID;

            if (searched == null )

                return NothingWasFound;
            else
                return (searched.ToList())[0];

        }
        


        public bool addQuestion(Question question)
        {
            if (!canAddQuestion(question))
            {
                return false;
            }



            DataBase.Base.Add(new Base()
            {
                TypeID = getTypeIDByName(question.Type),
                Answear = question.Answear,
                AuthorID = getAuthorIDByName(question.Author),
                Comment = question.Comment,
                DifficultyID = getDifficultiesIDByName(question.Difficulty),
                Name = question.Name,
                Year = question.Year
            });

            DataBase.SaveChanges();
            return true;


        }


        public List<Question> getAllQuestions()
        {
            List<Question> list = new List<Question>();

            var searched = (from c in DataBase.Base
                            select c).ToList();
            

            foreach(var c in searched)
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


        public List<Question> getFilteredQuestion(Question filter)
        {

            List<Question> list = new List<Question>();

            var searched = (from c in DataBase.Base where
                              ((filter.Answear == string.Empty) || (c.Answear.ToUpper().Contains(filter.Answear.ToUpper()))) &&
                              ((filter.Author == string.Empty) || (c.Authors.Name.ToUpper().Contains(filter.Author.ToUpper()))) &&
                              ((filter.Comment == string.Empty) || (c.Comment.ToUpper().Contains(filter.Comment.ToUpper()))) &&
                              ((filter.Difficulty == string.Empty) || (c.Difficulties.Name == filter.Difficulty)) &&
                              ((filter.Name == string.Empty) || (c.Name.ToUpper().Contains(filter.Name.ToUpper()))) &&
                              ((filter.Type == string.Empty) || (c.TypeOfQuestion.Name == filter.Type)) &&
                              ((filter.Year == 0) || (c.Year == filter.Year))  


                            
                                select c).ToList();



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


        //check if this ID exist and check by Name
        public bool canChangeQuestion(Question question)
        {
            var current = (from c in DataBase.Base where c.ID == question.ID select c).Any();
            if (!current) return false;

            var searched = (from c in DataBase.Base where (c.Name == question.Name) && (c.TypeOfQuestion.Name == question.Type) select c).Any();
            if (searched)
            {
                var temp = (from c in DataBase.Base where (c.Name == question.Name) && (c.TypeOfQuestion.Name == question.Type) select c).FirstOrDefault();
                if (temp.ID == question.ID)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            return true;

        }
        //Check if such question exist and if it can be changed
        public bool changeQuestion(Question question)
        {
            if (canChangeQuestion(question))
            {
                var searched = (from c in DataBase.Base where c.ID == question.ID select c).FirstOrDefault();
                searched.Name = question.Name;
                searched.Answear = question.Answear;
                searched.AuthorID = getAuthorIDByName(question.Author);
                searched.Comment = question.Comment;
                searched.DifficultyID = getDifficultiesIDByName(question.Difficulty);
                searched.TypeID = getTypeIDByName(question.Type);
                searched.Year = question.Year;

                DataBase.SaveChanges();

               return true;
            }
            else
                return false;
        
  }
        //First check if ID correct after check is question in any Contest
        public bool canDeleteQuestion(Question question)
        {
            var isIDCorrect = (from c in DataBase.Base where c.ID == question.ID select c).Any();
            if (!isIDCorrect) return false;
            var isQuestionInContest = (from c in DataBase.ContestToQuestion where c.QuestionID == question.ID select c).Any();
            return !isQuestionInContest;

        }
        //Firstly check question by method  canDeleteQuestion
        public bool deleteQuestion(Question question)
        {
            if (canDeleteQuestion(question))
            {
                var searched = (from c in DataBase.Base where c.ID == question.ID select c).FirstOrDefault();

                DataBase.Base.Remove(searched);
                DataBase.SaveChanges();

                
                
                return true;
            }
            else
                return false;
        }


        public Question getQuestionByID(int id)
        {
            var isExist = (from c in DataBase.Base where c.ID == id select c).FirstOrDefault();
            return new Question(isExist.ID, isExist.TypeOfQuestion.Name, isExist.Name, isExist.Answear, isExist.Year, isExist.Authors.Name, isExist.Difficulties.Name);


        }
    
    
    }
}
