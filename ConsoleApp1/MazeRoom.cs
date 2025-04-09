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
                    Random rand = new Random();
                    int randomNumber = rand.Next(2);
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
                    Environment.Exit(0);
                    break;

            }
        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("당신은 낯선곳에서 눈을 떴습니다.\n하지만 당신이 누군지 여기는 어딘지 기억이 나지 않습니다.\n일단 여기서 나가야 할 것 같습니다.");
            Console.WriteLine("당신 앞에 세 갈레 길이 있습니다. 어디로 가시겠습니까?");
            Console.WriteLine();

           
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
