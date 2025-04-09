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
           
        }

        public override void Next()
        {
            Game.Load("MazeRoom1");
        }

        public override void Render()
        {
            Console.Clear();

            Console.WriteLine("당신은 선택한 방향으로 이동 했다...");
            Console.WriteLine("당신은 이 방에 함정을 발동시켜 버렸고 벽에 타이머와 함께 퍼즐이 나왔다!");
        }

        public override void Result()
        {
            Console.WriteLine("당신은 시간내에 퍼즐을 풀어내 다음방으로 이동했다.");
            Console.WriteLine("당신은 시간내에 퍼즐을 풀어내지 못하고 방에서 수많은 가시가 튀어 나와 당신을 찔렀다...");
        }

        public override void Update()
        {
            
        }

        public override void Wait()
        {
            
        }
    }
}
