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
           
        }

        public override void Next()
        {
            Game.Load("MazeRoom1");
        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("당신은 선택한 방향으로 이동 했다...");
            Console.WriteLine("당신은 이 방에 함정을 발동시켜 버렸고 당신 발밑은 갑자기 사라졌다!");
        }

        public override void Result()
        {
            Random rand = new Random();
            int randNumber = rand.Next(20);
            if (Game.Player.Power <= randNumber)
            {
                Console.WriteLine("당신은 밧줄을 발견하고 재빠르게 붙잡고 올라가 다음 방으로 이동했다.");
            }
            else if (Game.Player.Power > randNumber)
            {
                int randNumber2 = rand.Next(5);
                Console.WriteLine("당신은 밧줄을 발견하고 재빠르게 붙잡고 올라갔지만 힘이 부족해 {0}데미지를 입었다.",randNumber2);
                Game.Player.Hp -= randNumber2;
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
