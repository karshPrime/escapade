using System;
using SplashKitSDK;

namespace escapade
{
    public class Program
    {
        public static void Main()
        {
            new Window("escapade", 1500, 900);
            SplashKit.HideMouse();

            bool quitGame = QuitGame();
            while (!quitGame)
            {
                SplashKit.ProcessEvents(); // Handle input to adjust player movement
                quitGame = QuitGame();
                SplashKit.ClearScreen();   // clears the screen
                
                Controls();
                Draw();
                
                SplashKit.RefreshScreen(60);
            }

        }

        // quit the game
        private static bool QuitGame()
        {
            return (SplashKit.KeyDown(KeyCode.QKey) || SplashKit.QuitRequested());
        }

        // Take user input and trigger specific action
        private static void Controls()
        {
            
        }

        // Draw everything on the screen
        private static void Draw()
        {
            
        }
    }
}
