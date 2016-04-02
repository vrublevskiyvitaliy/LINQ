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
        //Teams is different if name or year is different
        public List<Player> getAllPlayers()
        {
            List<Player> list = new List<Player>();
            var searched = (from c in DataBase.Players select c).ToList();

            foreach (var c in searched)
            {
                Player player = new Player(c.ID,c.Name,c.Year);
                list.Add(player);
            
            }

            return list;
        }

        public List<Player> getFilteredPlayers(Player filter)
        {
            List<Player> list = new List<Player>();
            var searched = (from c in DataBase.Players where
                            ((filter.Name == string.Empty) || (c.Name.ToUpper().Contains(filter.Name.ToUpper()))) &&
                            ((filter.Year == 0) || (filter.Year == c.Year))
                           
                            select c).ToList();

            foreach (var c in searched)
            {
                Player player = new Player(c.ID, c.Name, c.Year);
                list.Add(player);

            }

            return list; 
        
        }

        //Get teams by playerID
        public List<Team> getTeamByPlayer(Player player)
        {
            List<Team> list = new List<Team>();


            var searched = (from c in DataBase.PlayerToTeam where c.PlayerID == player.ID select c.Teams).ToList();

            foreach (var c in searched)
            {
                Team team = new Team(c.ID, c.Name, c.Year);
                list.Add(team);
            }
            
            return list;

        }




        public bool canAddPlayer(Player player)
        {
            var searched = (from c in DataBase.Players where (c.Name == player.Name) && (c.Year == player.Year) select c).Any();

            return !searched;

        }
        //check by name and year
        public bool canChangePlayer(Player player)
        {
            bool isExistPlayer = (from c in DataBase.Players where c.ID == player.ID select c).Any();
            if (!isExistPlayer) return false;
            
            return canAddPlayer(player);

        }
        //check is author exist and is author in Base
        public bool canDeletePlayer(Player player)
        {
            var isIDCorrect = (from c in DataBase.Players where c.ID == player.ID select c).Any();
            if (!isIDCorrect) return false;

            var searched = (from c in DataBase.PlayerToTeam where c.PlayerID == player.ID select c).Any();

            return !searched;

        }


        //Firstly check if can add
        public bool addPlayer(Player player)
        {
            if (canAddPlayer(player))
            {
                DataBase.Players.Add(new Players()
                {
                    Name = player.Name,
                    Year = player.Year
                }
                );

                DataBase.SaveChanges();

                return true;
            }
            else
                return false;


        }

        //Firstly check if can change
        public bool changePlayer(Player player)
        {
            if (canChangePlayer(player))
            {
                var searched = (from c in DataBase.Players where c.ID == player.ID select c).FirstOrDefault();

                searched.Name = player.Name;
                searched.Year = player.Year;

                DataBase.SaveChanges();

                return true;
            }
            else
                return false;

        }
        //Firstly check if can delete
        public bool deletePlayer(Player player)
        {
            if (canDeletePlayer(player))
            {

                var searched = (from c in DataBase.Players where c.ID == player.ID select c).FirstOrDefault();

                DataBase.Players.Remove(searched);

                DataBase.SaveChanges();

                return true;
            }
            else
                return false;


        }


        //return ID or NothingWasFound
        public int getIDOfPlayer(string name, int year)
        {
            var isExist = (from c in DataBase.Players where (c.Name == name) && (c.Year == year) select c).Any();

            if (!isExist) return NothingWasFound;

            var searched = (from c in DataBase.Players where (c.Name == name) && (c.Year == year) select c).FirstOrDefault();
            
            return searched.ID;

        }

        public Player getPlayerByID(int ID)
        {
            var searched = (from c in DataBase.Players where c.ID == ID select c).FirstOrDefault();

            Player player = new Player(searched.ID,searched.Name,searched.Year);
            
            return player;


        }




    }
}
