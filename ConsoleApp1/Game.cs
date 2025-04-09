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

        public static void Load(string loadName)
        {
            nextRoom = roomDic[loadName];
        }
        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ");
            Console.WriteLine("ㅁ       당신은 사망했습니다...    ㅁ");
            Console.WriteLine("ㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁㅁ");
            Console.WriteLine();
            Console.WriteLine(reason);

            gameOver = true;
        }

        

        private static bool gameOver;

        private static void Start()
        {
            gameOver = false;

            roomDic = new Dictionary<string, Room>();
            roomDic.Add("Title", new Title());
            roomDic.Add("MazeRoom", new MazeRoom());
            roomDic.Add("MazeRoom1", new MazeRoom1());
            roomDic.Add("BoxRoom", new BoxRoom());
            roomDic.Add("ClosedRoom", new ClosedRoom());
            roomDic.Add("SpeedTrap", new SpeedTrapRoom());
            roomDic.Add("PowerTrap", new PowerTrapRoom());
            roomDic.Add("PuzzleTrap", new PuzzleTrapRoom());





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
                nextRoom.Next();
            }
            End();
        }
    }

}
