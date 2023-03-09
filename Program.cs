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
    private static Mouse _cursor;
    private static Player _zul;
    private static Staff _staff;
    private static Layer[] _bgLayers;

    public static void Main()
    {
        new Window("escapade", 1563, 850);
        SplashKit.HideMouse();
        byte cooldownControl = 0;

        // initiating class instances 
        _cursor = new Mouse();
        _zul = new Player();
        _staff = new Staff();
        _bgLayers = { new Layer("background", 0),
                      new Layer("elements", 1.76f),
                      new Layer("platform", 2), // y = 572
                      new Layer("floor", 2),
                      new Layer("top_decor", 0.8f) };
        
        while (!QuitGame())
        {
            SplashKit.ProcessEvents(); // Handle input to adjust player movement
            SplashKit.ClearScreen();   // clears the screen
            
            Controls();
            _staff.UpdateGround(_zul.CordsY);
            _staff.Hover();
            
            // global cooldown for all 
            // WriteLine commands would be replaced by certain method calls
            cooldownControl += 1;
            //if (cooldownControl % 2  == 0) {Console.WriteLine("2 ticks cooldown");}
            //if (cooldownControl % 3  == 0) {Console.WriteLine("3 ticks cooldown");}
            //if (cooldownControl % 5  == 0) {Console.WriteLine("5 ticks cooldown");}
            //if (cooldownControl % 10 == 0) {Console.WriteLine("10 ticks cooldown");}
            //if (cooldownControl == 10) {cooldownControl = 0;}
            
            Display();
            SplashKit.RefreshScreen(60);
        }
    }

    // quit the game
    private static bool QuitGame()
    {
        return SplashKit.KeyDown(KeyCode.QKey) || SplashKit.QuitRequested();
    }

    // Take user input and trigger specific action
    private static void Controls()
    {
        // Individual If statements to accept multiple click at once
        if (SplashKit.KeyDown(KeyCode.AKey))
        {
            if (_position is 0 or -5844)
            {
                // move player around the screen
            }
            else
            {
                _position += 2;
                foreach (var layer in _bgLayers) { layer.Backward(); }   
            }
        } 
        else if (SplashKit.KeyDown(KeyCode.DKey))
        {
            if (_position == -5844)
            {
                // only allow the player to move
            }
            else
            {
                _position -= 2;
                foreach (var layer in _bgLayers) { layer.Forward(); }
            }
        }

        if (SplashKit.KeyDown(KeyCode.WKey)) { _zul.Jump(); }
        
        if (SplashKit.MouseClicked(MouseButton.LeftButton)) { _staff.Shoot(); }

        // Debugging use
        if (SplashKit.KeyDown(KeyCode.PKey))
        {
            Console.WriteLine($"Mouse Cords  : x={SplashKit.MouseX()},\t \t y={SplashKit.MouseY()}");
            Console.WriteLine($"Map Position : {_position}");
            Console.WriteLine($"Player Cords : x={_zul.CordsX},\t \t y={_zul.CordsY}");
            Console.WriteLine("===============");
        }
    }

    // Draw everything on the screen
    private static void Display()
    {
        // player
        _bgLayers[0].Display();     // background
        _bgLayers[1].Display();     // background elements: trees/stones
        _bgLayers[2].Display();     // walking platform
        _staff.Display();          // player's staff
        // enemies
        _bgLayers[3].Display();     // floor
        // jump flowers
        _bgLayers[4].Display();     // top decoration
        _cursor.Display();         // mouse cursor
    }
}
