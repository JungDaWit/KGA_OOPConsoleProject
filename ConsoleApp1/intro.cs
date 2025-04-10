using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class intro : Room
    {
        public override void Choice()
        {
            
        }

        public override void Next()
        {
            Game.Load("MazeRoom");
        }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("당신은 낯선 곳에서 눈을 떴다...");
            Console.WriteLine("하지만 당신이 누군지, 왜 여기 있는지 기억이 나지 않는다...");
            Console.WriteLine("일단 여기서 나가기 위해 주위를 둘러보았다.");
            Console.WriteLine();
            Console.WriteLine("눈앞에는 세 갈레 길이 보였고 선택해서 나아가면 될 거 같다.");
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
