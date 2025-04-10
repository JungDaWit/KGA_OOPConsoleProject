using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Title : Room
    {
        public override void Choice()
        {
            Util.Print("1. 게임 시작",ConsoleColor.Green);
            Util.Print("2. 게임 종료",ConsoleColor.Red);
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.Load("intro");
                    break;
                case ConsoleKey.D2:
                    Environment.Exit(0);
                    break;

            }
        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ");
            Console.WriteLine("ㅁ         길 찾기 게임             ㅁ");
            Console.WriteLine("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ");
            Console.WriteLine();

           
        }

        public override void Result()
        {
         
        }

        public override void Update()
        {
           
        }

        public override void Wait()
        {
            
        }
    }
}
