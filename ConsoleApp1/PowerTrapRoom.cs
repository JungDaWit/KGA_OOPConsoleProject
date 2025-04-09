using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PowerTrapRoom : Room
    {
        public override void Choice()
        {
            Console.WriteLine("1. 눈앞에 밧줄이 보인다! 밧줄을 잡자!");
            Console.WriteLine("2. 벽 틈이 보인다! 손을 넣어 잡자!");
            Console.WriteLine("3. 아무것도 잡지 않았다...");
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
                            Console.ReadKey();
                            Game.Load("MazeRoom1");
                        }
                        else if (Game.Player.Hp <= 0)
                        {
                            Game.GameOver("당신은 밧줄을 놓치고 끝없는 어둠속으로 추락했다...");
                        }

                    }
                    break;
            }
        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("당신은 선택한 방향으로 이동 했다...");
            Console.WriteLine("당신은 이 방에 함정을 발동시켜 버렸고 당신 발밑은 갑자기 사라졌다!");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                   Random rand = new Random();
                   int randNumber = rand.Next(20);
                   if (Game.Player.Power <= randNumber)
                   {
                       Console.WriteLine("당신은 밧줄을 재빠르게 붙잡고 올라가 다음 방으로 이동했다.");
                   }
                   else if (Game.Player.Power > randNumber)
                   {
                       int randNumber2 = rand.Next(5);
                       Console.WriteLine("당신은 밧줄을 재빠르게 붙잡고 올라갔지만 힘이 조금 부족해 {0}데미지를 입었다.",randNumber2);
                       Game.Player.Hp -= randNumber2;
                   }
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("벽 틈에 손을 넣어봤지만 손이 미끄러져 그대로 추락하고 말았다.");
                    Game.GameOver("당신은 끝없는 어둠속으로 추락했다...");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("당신은 아무것도 잡지 않았다...");
                    Game.GameOver("당신은 끝없는 어둠속으로 추락했다...");
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
