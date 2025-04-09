using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BoxRoom : Room
    {
        public override void Choice()
        {
            Console.WriteLine("1. 상자를 열어본다.");
            Console.WriteLine("2. 상자를 열지 않고 이전 방으로 돌아간다.");
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    if (Game.Player.Hp <= 0)
                    {
                        Game.GameOver("당신은 미믹에게 뼈 까지 씹혀버렸다...");
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
            Console.WriteLine("당신이 선택한 방향은 상자 하나만 있는 방이였다.");
            Console.WriteLine("당신은 상자를 수상하게 생각했다...");

        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("당신은 상자를 열어보았다");
                    Random rand = new Random();
                    int randNumber = rand.Next(8);
                    int randNumber2 = rand.Next(5);
                    if (randNumber == 0)
                    {
                        Console.WriteLine("상자 안에는 체력 포션을 흭득했다! 체력 {0} 업!",randNumber2);
                        Game.Player.Hp += randNumber2;
                    }
                    else if (randNumber == 1)
                    {
                        Console.WriteLine("상자 안에는 힘 포션을 흭득했다! 힘 {0} 업!", randNumber2);
                        Game.Player.Power += randNumber2;
                    }
                    else if (randNumber == 2)
                    {
                        Console.WriteLine("상자 안에는 지력 포션을 흭득했다! 지력 {0} 업!", randNumber2);
                        Game.Player.Intellect += randNumber2;
                    }
                    else if (randNumber == 3)
                    {
                        Console.WriteLine("상자 안에는 속도 포션을 흭득했다! 속도 {0} 업!", randNumber2);
                        Game.Player.Speed += randNumber2;
                    }
                    else
                    {
                        Console.WriteLine("상자는 미믹이였다! 손을 물려 {0}데미지를 입었다...", randNumber2);
                        Game.Player.Hp -= randNumber2;
                    }
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("당신은 상자를 수상하게 생각해 뒤돌아서 원래 방으로 돌아갔다.");
                    break;
            }
        }

        public override void Update()
        {
           
        }

        public override void Wait()
        {
            Console.WriteLine("진행하려면 아무키나 눌러주세요...");
            Console.ReadKey();
        }
    }
}
