using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Team
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Player> Players { get; private set; }

        public Team()
        {

        }

        public Team(int id, string name, int year, List<Player> list = null)
        {
            ID = id;
            Name = name;
            Year = year;
            Players = new List<Player>();
            if (list != null)
                Players.AddRange(list);

        }

        public bool addPlayer(Player player)
        {
            if (isPlayerInTeam(player))
                return false;
            else
                Players.Add(player);
            return true;

        }

        public bool isPlayerInTeam(Player player)
        {
            return Players.Contains(player);

        }

        public bool deletePlayerFromTeam(Player player)
        {
            if (isPlayerInTeam(player))
            {
                Players.Remove(player);
                return true;
            }
            else
                return false;

        }

        public bool Compare(Team newTeam)
        {
            return (ID == newTeam.ID) && (Name == newTeam.Name) && (Year == newTeam.Year);

        }
    }

}
