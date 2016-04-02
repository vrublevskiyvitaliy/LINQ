using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Contest
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public List<Team> Teams { get; private set; }

        public List<Question> Questions { get; private set; }

        public Contest()
        {
        }

        public Contest(int id, string name, int year)
        {
            ID = id;
            Name = name;
            Year = year;
            Teams = new List<Team>();
            Questions = new List<Question>();
        }

        public bool isQuestionInContest(Question question)
        {
            return Questions.Contains(question);

        }

        public bool addQuestion(Question question)
        {
            if (isQuestionInContest(question))
                return false;
            else
                Questions.Add(question);
            return true;
        }

        public bool deleteQuestion(Question question)
        {
            if (!isQuestionInContest(question))
                return false;
            else
                Questions.Remove(question);
            return true;

        }

        public bool isTeamInContest(Team team)
        {
            return Teams.Contains(team);
        }

        public bool addTeam(Team team)
        {
            if (isTeamInContest(team))
                return false;
            else
                Teams.Add(team);
            return true;

        }

        public bool deleteTeam(Team team)
        {
            if (!isTeamInContest(team))
                return false;
            else
                Teams.Remove(team);
            return true;
        }


        public bool Compare(Contest contest)
        { 
            return (Name == contest.Name) && (Year == contest.Year);
        }
    }

}
