using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Room
    {
        
        protected ConsoleKey input;
        public abstract void Render();
        public void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public abstract void Update();
        public abstract void Result();
        public abstract void Wait();
        public abstract void Next();
        public abstract void Choice();
    }
}
