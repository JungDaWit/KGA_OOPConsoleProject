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

        

        private static bool gameOver;

        private static void Start()
        {
            gameOver = false;

            roomDic = new Dictionary<string, Room>();
            roomDic.Add("Title", new Title());
            roomDic.Add("MazeRoom", new MazeRoom());
           


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
                nextRoom.Choice();
                nextRoom.Input();
                nextRoom.Update();
                nextRoom.Result();
                nextRoom.Next();
            }
            End();
        }
    }

}
