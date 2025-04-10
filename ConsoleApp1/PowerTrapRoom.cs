using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                   
                        Random rand = new Random();
                        int randNumber = rand.Next(20);
                        if (randNumber == 1)
                        {
                            Console.WriteLine("당신은 밧줄을 잡고 올라가 다음방으로 진입했다.");
                            Console.ReadKey();
                            Game.Clear("환한 빛이 보인다..!");
                        }
                        else if (Game.Player.Power >= randNumber)
                        {
                            Console.WriteLine("당신은 밧줄을 잡고 올라가 다음방으로 진입했다.");
                            Console.ReadKey();
                            Game.Load("MazeRoom1");
                        }
                        else if (Game.Player.Power < randNumber)
                        {
                            Console.WriteLine("당신은 팔은 힘이 빠지고 있다...");
                            Console.ReadKey();
                            Game.GameOver("당신은 밧줄을 놓치고 끝없는 어둠속으로 추락했다...");
                        }
                    break;
                case ConsoleKey.D2:
                    Game.GameOver("당신은 끝없는 어둠속으로 추락했다...");
                    break;
                case ConsoleKey.D3:
                    Game.GameOver("당신은 끝없는 어둠속으로 추락했다...");
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
                    Console.WriteLine("당신은 재빠르게 밧줄을 붙잡았다!");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("벽 틈에 손을 넣어봤지만 손이 미끄러져 그대로 추락하고 말았다.");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("당신은 아무것도 잡지 않았다...");
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
