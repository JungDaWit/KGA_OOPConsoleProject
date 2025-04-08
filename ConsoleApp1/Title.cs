using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Title : Room
    {
        private int index;
        private string[] menu = { "시작", "종료" };

        
        public override void Input()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    index = (index - 1 + menu.Length) % menu.Length;
                    break;
                case ConsoleKey.DownArrow:
                    index = (index + 1) % menu.Length;
                    break;
                case ConsoleKey.Enter:
                    if(index == 0)
                    {
                        Game.SetNextRoom("MazeRoom");
                    }
                    else if (index == 1)
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ");
            Console.WriteLine("ㅁ         길 찾기 게임           ㅁ");
            Console.WriteLine("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ");
            Console.WriteLine();
            for (int i = 0; i < menu.Length; i++)
            {
                if (i == index)
                   
                    Console.WriteLine($"▶{menu[i]}");
               
                else
                    Console.WriteLine($"  {menu[i]}");
            }
        }

        public override void Result()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
