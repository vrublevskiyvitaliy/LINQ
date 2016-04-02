using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Data.Entity;
//using System.Data.Entity.Core.Objects;
using System.Data;
using System.Data.Objects;

namespace AccesToDataBase
{
    public partial class AccesToDataBase
    {
        public List<string> getAllTypesName()
        {
            List<string> list = new List<string>();
            var searched = from c in DataBase.TypeOfQuestion select c.Name;
            list.AddRange(searched.ToList());
            return list;
        }
        public List<Common.TypeOfQuestion> getAllTypes()
        {
            List<Common.TypeOfQuestion> list = new List<Common.TypeOfQuestion>();
            var searched = (from c in DataBase.TypeOfQuestion select c).ToList();
            foreach (var c in searched)
            {
                Common.TypeOfQuestion type = new Common.TypeOfQuestion(c.ID, c.Name);
                list.Add(type);

            }
            
            return list;
        
        }


        //return ID or NothingWasFound
        public int getTypeIDByName(string name)
        {
            var searched = from c in DataBase.TypeOfQuestion where c.Name == name select c.ID;

            if (searched == null)
                return NothingWasFound;
            else
                return (searched.ToArray())[0];

        }
        //get Questions By Type Name
        public List<Question> getQuestionByType(string name)
        {
            List<Question> list = new List<Question>();
            Question filter = new Question(0, name, "", "", 0, "", "", "");
            list.AddRange(getFilteredQuestion(filter));
            return list;
        }
        //return name or string.Empty
        public string getTypeNameByID(int id)
        {
            string result = string.Empty;
            var searched = (from c in DataBase.TypeOfQuestion where c.ID == id select c.Name).ToArray();
            if (searched == null || searched.Length == 0)
                return result;
            else
                return (searched[0]);
        }

        public List<Common.TypeOfQuestion> getFilteredTypeName(string name)
        {
            List<Common.TypeOfQuestion> list = new List<Common.TypeOfQuestion>();
            var searched = (from c in DataBase.TypeOfQuestion where c.Name.ToUpper().Contains(name.ToUpper()) select c).ToList();
            foreach (var c in searched)
            {
                Common.TypeOfQuestion type = new Common.TypeOfQuestion(c.ID, c.Name);
                list.Add(type);

            }

            return list;
        
        }


        //check only by Name

        public bool isUniqueType(string name)
        {
            var searched = (from c in DataBase.TypeOfQuestion where c.Name == name select c).Any();


            return !searched;
        
        }

        public bool addType(Common.TypeOfQuestion type)
        {
            if (isUniqueType(type.Name))
            {
                DataBase.TypeOfQuestion.Add(new TypeOfQuestion()
                {
                    Name = type.Name
                }


                    );
                DataBase.SaveChanges();
                return true;

            }
            else
                return false;

        }

        public bool canDeleteType(Common.TypeOfQuestion type)
        { 
            var searched = (from c in DataBase.Base where c.TypeID == type.ID select c).Any();
            var v = (from c in DataBase.TypeOfQuestion where c.ID == type.ID select c).Any();

            return (!searched && v);
        }

        public bool changeType(Common.TypeOfQuestion type)
        {
            if (isUniqueType(type.Name))
            {
                var searched = (from c in DataBase.TypeOfQuestion where c.ID == type.ID select c).FirstOrDefault();

                
                searched.Name = type.Name;
                DataBase.SaveChanges();
                
                
                return true;
            }
            else
                return false;


        }

        //Firstly check if can be deleted and if it exist
        public bool deleteType(Common.TypeOfQuestion type)
        {
            if (canDeleteType(type))
            {
                var searched = (from c in DataBase.TypeOfQuestion where c.ID == type.ID select c).FirstOrDefault();
                DataBase.TypeOfQuestion.Remove(searched);
                DataBase.SaveChanges();



                return true;
            }
            else
                return false;
        }

    }
}
