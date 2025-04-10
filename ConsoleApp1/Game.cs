using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Game
    {
        private static Dictionary<string, Room> roomDic;
        private static Room nextRoom;
        private static Player player;
        public static Player Player { get { return player; } }

        public static void Load(string loadName)
        {
            nextRoom = roomDic[loadName];
        }
        public static void GameOver(string reason)
        {
            Console.Clear();
            Util.Print("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ", ConsoleColor.Red);
            Util.Print("ㅁ       당신은 사망했습니다...    ㅁ", ConsoleColor.Red);
            Util.Print("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ", ConsoleColor.Red);
            Console.WriteLine();
            Console.WriteLine(reason);
            Console.WriteLine();

            Console.WriteLine("타이틀로 돌아가려면 아무키나 누르세요");
            Console.ReadKey();
            player.Hp = 10;
            player.Power = 5;
            player.Intellect = 5;
            player.Speed = 5;
            Load("Title");
           
        }
        public static void playerInfo()
        {
            Util.Print("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ",ConsoleColor.Green);
            Util.Print("ㅁ                당신의 현재 상태                ㅁ", ConsoleColor.Green);
            Util.Print($"ㅁ   체력 : {player.Hp},   힘 : {player.Power},   지능 : {player.Intellect},   속도 : {player.Speed}  ㅁ", ConsoleColor.Green);
            Util.Print("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ", ConsoleColor.Green);
        }
        public static void Clear(string reason)
        {
            Console.Clear();
            Util.Print("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ",ConsoleColor.Yellow);
            Util.Print("ㅁ       미로를 탈출했습니다!       ㅁ", ConsoleColor.Yellow);
            Util.Print("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ", ConsoleColor.Yellow);
            Console.WriteLine();
            Console.WriteLine("아무키 입력시 게임 타이틀로 이동 합니다.");
            Console.ReadKey();
            player.Hp = 10;
            player.Power = 5;
            player.Intellect = 5;
            player.Speed = 5;
            Load("Title");

        }

        

        private static bool gameOver;

        private static void Start()
        {
            gameOver = false;

            roomDic = new Dictionary<string, Room>();
           
            roomDic.Add("Title", new Title());
            roomDic.Add("intro", new intro());
            roomDic.Add("MazeRoom", new MazeRoom());
            roomDic.Add("MazeRoom1", new MazeRoom1());
            roomDic.Add("BoxRoom", new BoxRoom());
            // roomDic.Add("ClosedRoom", new ClosedRoom());
            roomDic.Add("DoorRoom", new DoorRoom());
            roomDic.Add("SpeedTrap", new SpeedTrapRoom());
            roomDic.Add("PowerTrap", new PowerTrapRoom());
            roomDic.Add("PuzzleTrap", new PuzzleTrapRoom());


            player = new Player();
            player.Hp = 10;
            player.Power = 5;
            player.Intellect = 5;
            player.Speed = 5;





            nextRoom = roomDic["Title"];
        }
        private static void End()
        {

        }
        public static void Rnu()
        {
            Start();
            while (gameOver == false)
            {
                
                nextRoom.Render();
                Console.WriteLine();
                nextRoom.Choice();
                Console.WriteLine();
                nextRoom.Input();
                Console.WriteLine();
                nextRoom.Update();
                Console.WriteLine();
                nextRoom.Result();
                Console.WriteLine();
                nextRoom.Wait();
                Console.WriteLine();
                nextRoom.Next();
            }
            End();
        }
    }

}
