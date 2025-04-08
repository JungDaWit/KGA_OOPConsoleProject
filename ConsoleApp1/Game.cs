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

        public static void SetNextRoom(string roomName)
        {
            if (roomDic.ContainsKey(roomName))
                nextRoom = roomDic[roomName];
        }

        private static bool gameOver;

        private static void Start()
        {
            gameOver = false;

            roomDic = new Dictionary<string, Room>();
            roomDic.Add("Title", new Title());
            roomDic.Add("MazeRoom1", new MazeRoom1());


            nextRoom = roomDic["Title"];
        }
        private static void End()
        {

        }
        public static void Rnu()
        {
            Start();
            while (gameOver)
            {
                nextRoom.Render();
                nextRoom.Input();
                nextRoom.Update();
                nextRoom.Result();
            }
            End();
        }
    }
}
