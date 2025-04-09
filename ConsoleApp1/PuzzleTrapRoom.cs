using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PuzzleTrapRoom : Room
    {
        public override void Choice()
        {
            Console.WriteLine("1. 퍼즐을 푼다.");
            Console.WriteLine("2. 다시 입구로 돌아간다.");
            Console.WriteLine("3. 퍼즐 풀기를 포기한다.");
        }

        public override void Next()
        {

            switch (input)
            {
                case ConsoleKey.D1:
                    if (Game.Player.Hp == Game.Player.Hp)
                    {
                        Random rand = new Random();
                        int randNumber = rand.Next(30);
                        if (randNumber == 0)
                        {
                            Game.Clear("환한 빛이 보인다..!");
                        }
                        else if (randNumber > 0)
                        {
                            Console.WriteLine("다음 방으로 진입했다.");
                            Game.Load("MazeRoom1");
                        }

                    }
                    break;
                case ConsoleKey.D2:
                    if (Game.Player.Hp <= 0)
                    {
                        Game.GameOver("당신의 몸에는 수많은 구멍이 생겼다...");
                    }
                    else
                    {
                        Game.Load("MazeRoom1");
                    }
                    break;
            }
        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("당신은 선택한 방향으로 이동 했다...");
            Console.WriteLine("당신은 이 방에 함정을 발동시켜 버렸고 벽에 타이머와 함께 퍼즐이 나왔다!");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Random rand = new Random();
                    int randNumber = rand.Next(20);
                    if (randNumber <= Game.Player.Intellect)
                    {
                        Console.WriteLine("당신은 시간내에 퍼즐을 풀어내 다음방으로 이동했다.");
                    }
                    else
                    Console.WriteLine("당신은 시간내에 퍼즐을 풀어내지 못하고 방에서 수많은 가시가 튀어 나와 당신을 찔렀다...");
                    Console.ReadKey();
                    Game.GameOver("당신의 몸에는 수많은 구멍이 생겼다...");
                    break;
                case ConsoleKey.D2:
                    Random rand2 = new Random();
                    int randNumber2 = rand2.Next(5);
                    Console.WriteLine("당신은 원래방으로 빠르게 되돌아 갔지만 발을 헛 디뎌 {0}데미지를 입었다...", randNumber2);
                    Game.Player.Hp -= randNumber2;
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("당신은 머리가 새하얗게 변하며 멍 때려 버렸다...");
                    Console.ReadKey();
                    Game.GameOver("당신의 몸에는 수많은 구멍이 생겼다...");
                    break;

            }
            
        }

        public override void Update()
        {
            
        }

        public override void Wait()
        {
            Console.WriteLine("계속...");
            Console.ReadKey();
        }
    }
}
