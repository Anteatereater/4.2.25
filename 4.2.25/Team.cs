using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._25
{
    internal class Team:ITeam
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void RemovePlayer(Player player) 
        {
            players.Remove(player); 
        }
    }
}
