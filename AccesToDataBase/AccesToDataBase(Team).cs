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
        //Teams are different if name ot year is different
        //
        //
        public List<Team> getAllTeams()
        {
            List<Team> list = new List<Team>();

            var searched = (from c in DataBase.Teams select c).ToList();

            foreach (var c in searched)
            {
                Team team = new Team(c.ID, c.Name, c.Year);
                list.Add(team);
            
            }

            return list;
        }

        public List<Team> getFilteredTeams(Team filter)
        {
            List<Team> list = new List<Team>();
            var searched = (from c in DataBase.Teams
                            where
                                ((filter.Name == string.Empty) || (c.Name.ToUpper().Contains(filter.Name.ToUpper()))) &&
                                ((filter.Year == 0) || (filter.Year == c.Year))

                            select c).ToList();

            foreach (var c in searched)
            {
                Team team = new Team(c.ID, c.Name, c.Year);
                list.Add(team);

            }

            return list; 
        
        
        }


        public List<Player> getPlayersByTeam(Team team)
        {
            List<Player> list = new List<Player>();

            var searched = (from c in DataBase.PlayerToTeam where c.TeamID == team.ID select c.Players).ToList();

            foreach(var c in searched)
            {
                Player player = new Player(c.ID, c.Name, c.Year);
                list.Add(player);

            }

            return list;
        
        }







        //Check by name and year
        public bool canAddTeam(Team team)
        {
            var searched = (from c in DataBase.Teams where (c.Name == team.Name) && (c.Year == team.Year) select c).Any();

            return !searched;
        }
        //Check if team exist and after chek if can change
        public bool canChangeTeam(Team team)
        {
            var isExistTeam = (from c in DataBase.Teams where c.ID == team.ID select c).Any();
            if (!isExistTeam) return false;
            return canAddTeam(team);

        }


        public bool canDeleteTeam(Team team)
        {
            var isExistTeam = (from c in DataBase.Teams where c.ID == team.ID select c).Any();
            if (!isExistTeam) return false;

            var searched = (from c in DataBase.ContestToTeam where c.TeamID == team.ID select c).Any();
            return !searched;
        }

        public bool addTeam(Team team)
        {
            if (canAddTeam(team))
            {
                DataBase.Teams.Add(new Teams()
                {
                    Name = team.Name,
                    Year = team.Year
                }
                );

                DataBase.SaveChanges();

                return true;
            }
            else
                return false;


        }

        //Firstly check if can change
        public bool changeTeam(Team team)
        {
            if (canChangeTeam(team))
            {
                var searched = (from c in DataBase.Teams where c.ID == team.ID select c).FirstOrDefault();

                searched.Name = team.Name;
                searched.Year = team.Year;

                DataBase.SaveChanges();

                return true;
            }
            else
                return false;

        }
        //Firstly check if can delete 
        //
        public bool deleteTeam(Team team)
        {
            if (canDeleteTeam(team))
            {
                if (deleteAllPlayersFromTeam(team))
                {
                    var searched = (from c in DataBase.Teams where c.ID == team.ID select c).FirstOrDefault();

                    DataBase.Teams.Remove(searched);

                    DataBase.SaveChanges();

                    return true;
                }
                else return false;
            }
            else
                return false;


        }


        public bool deletePlayerFromTeam(Team team, Player player)
        {
            if (!isPlayerInTeam(team,player)) return false;
            var searched = (from c in DataBase.PlayerToTeam where (c.PlayerID == player.ID) && (c.TeamID == team.ID) select c).FirstOrDefault();
            DataBase.PlayerToTeam.Remove(searched);
            DataBase.SaveChanges();

            return true;

            
        }

        public bool deleteAllPlayersFromTeam(Team team)
        {
            var isExist = (from c in DataBase.Teams where c.ID == team.ID select c).Any();
            if (!isExist) return false;

            var searched = (from c in DataBase.PlayerToTeam where c.TeamID == team.ID select c.Players).ToList();
            foreach (var c in searched)
            {
                Player player = new Player(c.ID, c.Name, c.Year);
                deletePlayerFromTeam(team, player);

            
            }
            return true;

        
        }


        public bool isPlayerInTeam(Team team, Player player)
        {
            var isConection = (from c in DataBase.PlayerToTeam where (c.PlayerID == player.ID) && (c.TeamID == team.ID) select c).Any();
            return isConection;
        
        }

        public bool addPlayerInTeam(Team team, Player player)
        {
            if (isPlayerInTeam(team, player)) return false;

            DataBase.PlayerToTeam.Add(new PlayerToTeam()
            {
                PlayerID = player.ID,
                TeamID = team.ID

            });
            DataBase.SaveChanges();

            return true;
        
        }

        public Team getTeamByID(int id)
        {
            var searched = (from c in DataBase.Teams where c.ID == id select c).FirstOrDefault();

            return new Team(searched.ID, searched.Name, searched.Year);

        
        }



    }
}
