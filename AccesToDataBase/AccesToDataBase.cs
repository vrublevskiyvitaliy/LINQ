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
        // IntelectualGamesImprovedEntities1 DataBase;

        IntelectualGamesImprovedEntities DataBase;

        public static int NothingWasFound = -1;
        public AccesToDataBase()
        {
            DataBase = new IntelectualGamesImprovedEntities();

            DataBase.Authors.Load();
            DataBase.Base.Load();
            DataBase.Contests.Load();
            DataBase.ContestToQuestion.Load();
            DataBase.ContestToTeam.Load();
            DataBase.Difficulties.Load();
            DataBase.Players.Load();
            DataBase.PlayerToTeam.Load();
            DataBase.Teams.Load();
            DataBase.TypeOfQuestion.Load();

        }



        public List<string> getAllDifficulties()
        {
            List<string> list = new List<string>();
            var searched = from c in DataBase.Difficulties select c.Name;
            list = searched.ToList();
            return list;

        }

        


    }
}
