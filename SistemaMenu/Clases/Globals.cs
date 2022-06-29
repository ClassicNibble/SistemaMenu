using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clases
{
    public class Globals
    {


        public static bool pause = false;
        public static bool backMenu = true;

        public static bool PausekeyPress = false;

        public enum GameStates
        {
            MainMenu,
            InGame,
            Paused,
            Exit
        }
        public static GameStates CurrentGameState = GameStates.MainMenu;


    };

}
