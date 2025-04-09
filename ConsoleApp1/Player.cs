using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        private int hp;
        public int Hp { get { return hp; } set { hp = value; } }
        private int power;
        public int Power { get { return power; } set { power = value; } }
        private int intellect;
        public int Intellect { get { return intellect; } set { intellect = value; } }
        private int speed;
        public int Speed { get { return speed; } set { speed = value; } }
    }
}
