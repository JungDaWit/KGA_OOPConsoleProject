﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SpeedTrapRoom : Room
    {
        public override void Choice()
        {
            Console.WriteLine("1. 일단 빠르게 앞으로 뛴다.");
            Console.WriteLine("2. 뛰어도 늦을 거 같다 포기하자.");
            Console.WriteLine("3. 돌아왔던 길이 더 가깝다 이쪽으로 뛰자.");
        }

        public override void Next()
        {
            switch (input)
            {


                case ConsoleKey.D1:
                        Random rand = new Random();
                        int randNumber = rand.Next(30);
                        if(randNumber == 0)
                        {
                            Console.WriteLine("당신은 벽이 좁아지는 속도보다 빠르게 달려 좁아지는 벽 틈에서 나왔다.");
                            Console.ReadKey();
                            Game.Clear("환한 빛이 보인다..!");
                        }
                        else if(Game.Player.Speed >= randNumber)
                        {
                            Console.WriteLine("당신은 벽이 좁아지는 속도보다 빠르게 달려 좁아지는 벽 틈에서 나왔다.");
                            Console.ReadKey();
                            Game.Load("MazeRoom1");
                        }
                        else if(Game.Player.Speed < randNumber)
                        {
                            Console.WriteLine("당신은 미처 벽에서 탈출하지 못하였다.");
                            Console.ReadKey();
                            Game.GameOver("당신은 곤죽이 되었다...");
                        }
                    break;
                case ConsoleKey.D2:
                    Game.GameOver("당신은 곤죽이 되었다...");
                    break;
                case ConsoleKey.D3:
                    if (Game.Player.Hp <= 0)
                    {
                        Game.GameOver("당신은 곤죽이 되었다...");
                    }
                    else
                    {
                        Game.Load("MazeRoom");
                    }
                    break;





            }
        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("당신은 선택한 방향으로 이동 했다...");
            Console.WriteLine("당신은 이 방에 함정을 발동시켜 버렸고 양쪽 벽이 점점 좁아지고 있다!");
            Console.WriteLine();

        }

        public override void Result()
        {
            switch (input)
            {
                
                case ConsoleKey.D1:
                    Console.WriteLine("당신은 앞만 보고 전력질주했다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("함정이 발동되자 당신은 다리에 힘이 풀려버렸다.");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("벽이 좁아 지는걸 보고 뒤로 빠르게 뛰었다.");
                    Random rand2 = new Random();
                    int randNumber2 = rand2.Next(5);
                    Console.WriteLine("당신은 원래방으로 빠르게 되돌아 갔지만 발을 헛 디뎌 {0}데미지를 입었다...",randNumber2);
                    Game.Player.Hp -= randNumber2;
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
