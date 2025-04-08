using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Title : Room
    {

        
        public  void Input()
        {
           
        }

        public override void Render()
        {
           // Console.Clear();

            Console.WriteLine("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ");
            Console.WriteLine("ㅁ         길 찾기 게임             ㅁ");
            Console.WriteLine("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ");
            Console.WriteLine();

            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 게임 종료");
        }

        public override void Result()
        {
         
        }

        public override void Update()
        {
           
        }
    }
}
