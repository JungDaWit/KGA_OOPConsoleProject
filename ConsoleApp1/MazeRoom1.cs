using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MazeRoom1 : Room
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
            Console.Clear(); // TODO : 1번 선택시 화면이 클리어 되지도 않고 랜더 출력도 안되는 문제 수정해야함

            Console.WriteLine("당신은 처음과 비슷해 보이는 방으로 왔다.");
            Console.WriteLine("당신 앞에 세 갈레 길이 있다... 어디로 갈까?");
            Console.WriteLine();
            Game.playerInfo();

        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.Print("당신은 앞으로 이동했다.", ConsoleColor.Yellow);
                    break;
                case ConsoleKey.D2:
                    Util.Print("당신은 왼쪽 길로 이동했다.", ConsoleColor.Green);
                    break;
                case ConsoleKey.D3:
                    Util.Print("당신은 오른쪽 길로 이동했다.", ConsoleColor.Red);
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
