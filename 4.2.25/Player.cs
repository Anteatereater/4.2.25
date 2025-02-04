using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._25
{
    internal class Player
    {
        private string name;
        private string position;

        public Player(string name, string position)
        {
            this.name = name;
            this.position = position;
        }
        public Player()
        {
            
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
