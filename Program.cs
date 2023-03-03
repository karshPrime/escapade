using System;
using SplashKitSDK;

namespace escapade
{
    public class Program
    {
        public static void Main()
        {
            new Window("escapade", 1563, 900);
            SplashKit.HideMouse();

            Mouse cursor = new Mouse();
            Layers layers = new Layers();

            bool quitGame = QuitGame();
            while (!quitGame)
            {
                SplashKit.ProcessEvents(); // Handle input to adjust player movement
                quitGame = QuitGame();
                SplashKit.ClearScreen();   // clears the screen
                
                Controls(layers);
                Draw(cursor, layers);
                
                SplashKit.RefreshScreen(60);
            }

        }

        // quit the game
        private static bool QuitGame()
        {
            return (SplashKit.KeyDown(KeyCode.QKey) || SplashKit.QuitRequested());
        }

        // Take user input and trigger specific action
        private static void Controls(Layers layers)
        {
            // Individual If statements to accept multiple click at once
            if (SplashKit.KeyDown(KeyCode.AKey)) {             // left
                layers.Move(false);
            } else if (SplashKit.KeyDown(KeyCode.DKey)) {      // right
                layers.Move(true);
            } 
        }

        // Draw everything on the screen
        private static void Draw(Mouse cursor, Layers layers)
        {
            layers.Draw(0);             // background
            layers.Draw(1);             // background elements: trees/stones
            layers.Draw(2);             // walking platform
            // player
            layers.Draw(3);             // floor
            layers.Draw(4);             // top decoration
            cursor.Draw();              // mouse cursor
        }
    }
}
