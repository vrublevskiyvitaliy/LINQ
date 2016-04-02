using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace AccesToDataBase
{
    public partial class AccesToDataBase
    {
        public List<Contest> getAllContests()
        {
            List<Contest> list = new List<Contest>();

            var searched = (from c in DataBase.Contests select c).ToList();

            foreach(var c in searched)
            {
                Contest contest = new Contest(c.ID, c.Name, c.Year);
                list.Add(contest);
            }

            return list;
        }

        public List<Contest> getFilteredContests(Contest filter)
        {
            List<Contest> list = new List<Contest>();


            var searched = (from c in DataBase.Contests
                            where
                                ((filter.Name == string.Empty) || (c.Name.ToUpper().Contains(filter.Name.ToUpper()))) &&
                                ((filter.Year == 0) || (c.Year == filter.Year))
                            select c
                                ).ToList();

            foreach (var c in searched)
            {
                Contest tmp = new Contest(c.ID, c.Name, c.Year);
                list.Add(tmp);

            }
            return list;
        }
        //Get  questions by contestID
        public List<Question> getQuestionsByContest(Contest contest)
        {
            List<Question> list = new List<Question>();

            var searched = (from c in DataBase.ContestToQuestion where c.ContestID == contest.ID select c.QuestionID).ToList();

            foreach (var c in searched)
            {
                Question question = getQuestionByID(c);
                list.Add(question);
            }

            return list;

        }
        //check by question ID
        public bool isQuestionInContest(Contest contest, Question question)
        {
            var searched = (from c in DataBase.ContestToQuestion where (c.ContestID == contest.ID) && (c.QuestionID == question.ID) select c).Any();
            return searched;
        }
        //get teams by contestID
        public List<Team> getTeamsByContest(Contest contest)
        {
            List<Team> list = new List<Team>();

            var searched = (from c in DataBase.ContestToTeam where c.ContestID == contest.ID select c.Teams).ToList();

            foreach (var c in searched)
            {
                Team team = new Team(c.ID, c.Name, c.Year);
                list.Add(team);
            
            }

            return list;
        }


        public bool isTeamInContest(Contest contest, Team team)
        {
            var searched = (from c in DataBase.ContestToTeam where (c.ContestID == contest.ID) && (team.ID == c.TeamID) select c).Any();
            return searched;
        }

        public bool canAddQuestionToContest(Contest contest, Question question)
        {
           
            return !isQuestionInContest(contest, question);    

        }

        public bool canAddTeamToContest(Contest contest, Team team)
        {
            return !isTeamInContest(contest, team);
        
        }
        //firstly check if can add
        public bool addQuestionToContest(Contest contest, Question question)
        {
            if (canAddQuestionToContest(contest, question))
            {

                DataBase.ContestToQuestion.Add(new ContestToQuestion()
                    {
                        ContestID = contest.ID,
                        QuestionID = question.ID
                    });

                DataBase.SaveChanges();
                return true;
            }
            else
                return false;
        
        }
        //Check iif can add
        public bool addTeamToContest(Contest contest, Team team)
        {
            if (canAddTeamToContest(contest, team))
            {
                DataBase.ContestToTeam.Add(new ContestToTeam() 
                {
                    ContestID = contest.ID,
                    TeamID = team.ID
                });

                DataBase.SaveChanges();
                return true;
            }
            else
                return false;
        }
        //Firstly check if team in contest
        public bool deleteTeamFromContest(Contest contest, Team team)
        {
            if (isTeamInContest(contest, team))
            {
                var searched = (from c in DataBase.ContestToTeam where (contest.ID == c.ContestID) && (team.ID == c.TeamID) select c).FirstOrDefault();

                DataBase.ContestToTeam.Remove(searched);

                DataBase.SaveChanges();


                return true;
            }
            else
                return false;
        }

        //check if  question is in contest
        public bool deleteQuestionFromContest(Contest contest, Question question)
        {
            if (isQuestionInContest(contest, question))
            {
                var searched = (from c in DataBase.ContestToQuestion where (contest.ID == c.ContestID) && (question.ID == c.QuestionID) select c).FirstOrDefault();

                DataBase.ContestToQuestion.Remove(searched);

                DataBase.SaveChanges();


                return true;
            }
            else
                return false;


        }
        
        //

        //check by name and year
        //
        public bool canAddContest(Contest contest)
        {
            var searched = (from c in DataBase.Contests where (c.Name == contest.Name) && (c.Year == contest.Year) select c).Any();
            return !searched;

        }
        //check by name and year 
        public bool canChangeContest(Contest contest)
        {
            return canAddContest(contest);
        
        }
        //check if exist and 
        public bool canDeleteContest(Contest contest)
        {
            var searched = (from c in DataBase.Contests where contest.ID == c.ID select c).Any();
            return searched;

        }
        //firstly check if can add
        public bool addContest(Contest contest)
        {
            if (canAddContest(contest))
            {
                DataBase.Contests.Add(new Contests()
                {
                    Name = contest.Name,
                    Year = contest.Year

                });
                DataBase.SaveChanges();

                return true;
            }
            else
                return false;
        }
        //Find contest by ID and change
        public bool changeContest(Contest contest)
        {
            if (canChangeContest(contest))
            {
                var searched = (from c in DataBase.Contests where c.ID == contest.ID select c).FirstOrDefault();

                searched.Name = contest.Name;
                searched.Year = contest.Year;

                DataBase.SaveChanges();

                return true;
            }
            else
                return false;
        }
        //For each question in contest run method deleteQuestionFromContest
        public bool deleteAllQuestionsFromContest(Contest contest)
        {
            List<Question> list = getQuestionsByContest(contest);
            foreach (var c in list)
            {
                deleteQuestionFromContest(contest, c);

            
            }

            return true;
        
        }
        //For each team in contest run method deleteTeamFromContest
        public bool deleteAllTeamsFromContest(Contest contest)
        {
            List<Team> list = getTeamsByContest(contest);

            foreach (var c in list)
            {
                deleteTeamFromContest(contest, c);
            
            }
            return true;

        }


        //Find by ID and delete firstly all question and teams
        public bool deleteContest(Contest contest)
        {
            if (canDeleteContest(contest))
            {
                deleteAllTeamsFromContest(contest);
                deleteAllQuestionsFromContest(contest);
                var searched = (from c in DataBase.Contests where c.ID == contest.ID select c).FirstOrDefault();

                DataBase.Contests.Remove(searched);

                DataBase.SaveChanges();

                return true;
            }
            else
                return false;

        }


    }
}
