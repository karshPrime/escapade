using System;
using SplashKitSDK;

namespace escapade
{
    public class Program
    {
        public static void Main()
        {
            new Window("Camera Test", 800, 800);
            SplashKit.HideMouse();

            bool quitGame = QuitGame();
            while (!quitGame)
            {
                quitGame = QuitGame();
            }

        }

        // quit the game
        private static bool QuitGame()
        {
            // different ways to quit the game
        }

        // Take user input and trigger specific action
        public static void Controls()
        {
            
        }

        // Draw everything on the screen
        public static void Draw()
        {
            
        }
    }
}
