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
            Game.Load("MazeRoom1");
        }

        public override void Render()
        {
            Console.Clear();

            Random rand = new Random();
            int randNumber = rand.Next(3);
            if(randNumber == 0)
            {
                Console.WriteLine("당신은 다음 방으로 이동했다.");
            }
            else if (randNumber == 1)
            {
                Console.WriteLine("당신은 날아오는 침에 맞아 {0}데미지를 입고 다음 방으로 이동했다.");
            }
            else if (randNumber == 2)
            {
                Console.WriteLine("당신은 벽에 밧줄을 발견하고 밧줄을 잡고 다음 방으로 이동했다.");
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
            
        }
    }
}
