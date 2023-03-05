using System;
using SplashKitSDK;
using Escapade.SrcCharacters;
using Escapade.SrcEntities;

/*                    _
 *     _ __ ___   __ _(_)_ __
 *    | '_ ` _ \ / _` | | '_ \
 *    | | | | | | (_| | | | | |
 *    |_| |_| |_|\__,_|_|_| |_|
 */

namespace Escapade;

public class Program
{
    private static short _position;
    public static void Main()
    {
        new Window("escapade", 1563, 850);
        SplashKit.HideMouse();

        // initiating class instances 
        Mouse cursor = new Mouse();
        Layer[] bgLayers = { new Layer("background", 0),
            new Layer("elements", 1.76f),
            new Layer("platform", 2), // y = 572
            new Layer("floor", 2),
            new Layer("top_decor", 0.8f) };
        
        while (!QuitGame())
        {
            SplashKit.ProcessEvents(); // Handle input to adjust player movement
            SplashKit.ClearScreen();   // clears the screen

            Controls(bgLayers);
            Display(bgLayers, cursor);
                
            SplashKit.RefreshScreen(60);
        }
    }

    // quit the game
    private static bool QuitGame()
    {
        return SplashKit.KeyDown(KeyCode.QKey) || SplashKit.QuitRequested();
    }

    // Take user input and trigger specific action
    private static void Controls(Layer[] layers)
    {
        // Individual If statements to accept multiple click at once
        if (SplashKit.KeyDown(KeyCode.AKey))
        {
            if (_position is 0 or -5844) return;
            _position += 2;
            foreach (var layer in layers) { layer.Backward(); }
        } 
        else if (SplashKit.KeyDown(KeyCode.DKey))
        {
            if (_position == -5844) return;
            _position -= 2;
            foreach (var layer in layers) { layer.Forward(); }
        }

        // Debugging use
        if (SplashKit.KeyDown(KeyCode.PKey))
        {
            Console.WriteLine($"Mouse Cords: x={SplashKit.MouseX()}, y={SplashKit.MouseY()}");
        }
    }

    // Draw everything on the screen
    private static void Display(Layer[] bgLayer, Mouse cursor)
    {
        bgLayer[0].Display();     // background
        bgLayer[1].Display();     // background elements: trees/stones
        bgLayer[2].Display();     // walking platform
        // player
        // enemies
        bgLayer[3].Display();     // floor
        // jump flowers
        bgLayer[4].Display();     // top decoration
        cursor.Display();         // mouse cursor
    }
}