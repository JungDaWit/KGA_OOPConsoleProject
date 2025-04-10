using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MazeRoom : Room
    {
       
        public override void Choice()
        {
            Console.WriteLine("1. 앞으로 간다");
            Console.WriteLine("2. 왼쪽으로 간다");
            Console.WriteLine("3. 오른쪽으로 간다");
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.Load("DoorRoom");
                    break;

                case ConsoleKey.D3:
                    Random rand = new Random();
                    int randomNumber = rand.Next(3);
                    if (randomNumber == 0)
                    {
                        Game.Load("SpeedTrap");
                    }
                    else if (randomNumber == 1)
                    {
                        Game.Load("PowerTrap");
                    }
                    else
                        Game.Load("PuzzleTrap");
                    break;

                case ConsoleKey.D2:
                    Game.Load("BoxRoom");
                    break;

            }
        }

        public override void Render()
        {
            Console.Clear();

          //  Console.WriteLine("당신은 낯선 곳에서 눈을 떴다...");
          //  Console.WriteLine("하지만 당신이 누군지, 왜 여기 있는지 기억이 나지 않는다...");
            Console.WriteLine("당신 앞에 세 갈레 길이 있다... 어디로 갈까?");
            Console.WriteLine();
            Game.playerInfo();
           
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("당신은 앞으로 이동했다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("당신은 왼쪽 길로 이동했다.");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("당신은 오른쪽 길로 이동했다.");
                    break;
            }
        }

        public override void Update()
        {
           
        }

        public override void Wait()
        {
            Console.WriteLine("진행하려면 아무키나 눌러주세요...");
            Console.ReadKey();
        }
    }
}
