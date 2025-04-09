using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ClosedRoom : Room
    {

        public override void Choice()
        {
           
        }

        public override void Next()
        {
          // switch (input)
          // {
          //     case Console.WriteLine("환한 빛이 보인다!")://조건 수정
          //         Game.Clear("당신은 빛을따라 쭉 달렸습니다!");
          //         break;
          //     case Console.WriteLine("당신은 다음 방으로 이동했다."):
          //         Game.Load("MazeRoom");
          //         break;



            
        }

        public override void Render()
        {
            Console.Clear();

            Random rand = new Random();
            int randNumber = rand.Next(3);
            if(randNumber == 0)
            {
                Random rand1 = new Random();
                int randNumber1 = rand1.Next(50);
                if (randNumber1 == 0)
                {
                    Console.WriteLine("환한 빛이 보인다!");
                    Console.ReadKey();
                    Game.Clear("당신은 빛을따라 쭉 달렸습니다!");
                }
                else
                {
                    Console.WriteLine("당신은 다음 방으로 이동했다.");
                    Console.ReadKey();
                    Game.Load("MazeRoom1");
                }
            }
            else if (randNumber == 1)
            {
                Random rand2 = new Random();
                int randNumber2 = rand2.Next(3);
                    Console.WriteLine("당신은 날아오는 침에 맞아 {0}데미지를 입고 다음 방으로 이동했다.",randNumber2);
                Game.Player.Hp -= randNumber2;
                Game.Load("MazeRoom1");
            }
            else if (randNumber == 2)
            {
                Random rand3 = new Random();
                int randNumber3 = rand3.Next(20);
                if (randNumber3 <= Game.Player.Power)
                {
                    Console.WriteLine("당신은 벽에 밧줄을 발견하고 밧줄을 잡고 다음 방으로 이동했다.");
                    Game.Load("MazeRoom1");
                }
                else
                {
                    Console.WriteLine("당신은 밧줄을 잡고 올라갈 힘이 없어 원래 방으로 되돌아갔다.");
                    Game.Load("MazeRoom");
                }
            }
           
        }

        public override void Result()
        {
            
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
