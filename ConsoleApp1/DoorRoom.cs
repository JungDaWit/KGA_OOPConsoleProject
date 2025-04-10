using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DoorRoom : Room
    {
        public override void Choice()
        {
            Console.WriteLine("1. 문을 밀어본다.");
            Console.WriteLine("2. 이전 방으로 돌아간다...");
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Random rand = new Random();
                    int randNumber = rand.Next(50);
                    if (Game.Player.Power > randNumber)
                    {
                        Console.WriteLine("당신은 문을 밀고 길을 따라 걸었다...");
                        Console.ReadKey();
                        Game.Load("MazeRoom1");
                    }
                    else if (Game.Player.Power == randNumber )
                    {
                        Console.WriteLine("환한 빛이 보인다..!");
                        Console.ReadKey();
                        Game.Clear("당신은 이 미궁에서 탈출했다..!");
                    }
                    else if (Game.Player.Power < randNumber)
                    {
                        Console.WriteLine("힘이 부족해 문이 밀리지 않는다...");
                        Console.WriteLine("문을 밀려고 힘을 많이쓰자 체력이 떨어졌다...{0}데미지를 입고 원래 방으로 돌아 갔다.", 1);
                        Game.Player.Hp -= 1;
                        
                        Console.ReadKey();
                        Game.Load("MazeRoom");
                    }
                    if(Game.Player.Hp == 0)
                    {
                        Game.GameOver("당신은 체력을 다해 그자리에서 일어나지 못했다...");
                    }
                    break;
                case ConsoleKey.D2:
                    Game.Load("MazeRoom");
                    break;
            }
        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("문이 있는 방이다...");
            Console.WriteLine("문을 밀면 열 수 있을것 같다.");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("당신은 문을 밀어보았다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("당신은 이전 방으로 돌아갔다...");
                    break;
            }
        }

        public override void Update()
        {
           
        }

        public override void Wait()
        {
            Console.WriteLine("계속...");
          
            //Console.ReadKey();
        }
    }
}
