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
                        int randNumber = rand.Next(20);
                        if (randNumber == 1)
                        {
                            Console.WriteLine("당신은 시간내에 퍼즐을 풀어내어 다음 방으로 진입했다.");
                            Console.ReadKey();
                            Game.Clear("환한 빛이 보인다..!");
                        }
                        else if (Game.Player.Intellect >= randNumber)
                        {
                            Console.WriteLine("당신은 시간내에 퍼즐을 풀어내어 다음 방으로 진입했다.");
                            Console.ReadKey();
                            Game.Load("MazeRoom1");
                        }
                        else if(Game.Player.Intellect < randNumber)
                        {
                            Console.WriteLine("당신은 퍼즐을 시간내에 풀지 못하였다...");
                            Console.ReadKey();
                            Game.GameOver("당신의 몸에는 수많은 구멍이 생겼다...");
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
                case ConsoleKey.D3:
                    Game.GameOver("당신의 몸에는 수많은 구멍이 생겼다...");
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
                    Console.WriteLine("당신은 집중해서 퍼즐을 풀어나갔다.");
                    break;
                case ConsoleKey.D2:
                    Random rand2 = new Random();
                    int randNumber2 = rand2.Next(5);
                    Util.Print($"당신은 원래방으로 빠르게 되돌아 갔지만 발을 헛 디뎌 {randNumber2}데미지를 입었다...",ConsoleColor.Red);
                    Game.Player.Hp -= randNumber2;
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("당신은 머리가 새하얗게 변하며 멍 때려 버렸다...");
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
