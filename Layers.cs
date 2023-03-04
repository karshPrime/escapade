using SplashKitSDK;

/*     _
 *    | | __ _ _   _  ___ _ __ ___
 *    | |/ _` | | | |/ _ | '__/ __|
 *    | | (_| | |_| |  __| |  \__ \
 *    |_|\__,_|\__, |\___|_|  |___/
 *             |___/
 */

namespace escapade;

public class Layers
{
    private readonly Bitmap _background = new Bitmap("background", "background.png"); 
    private readonly Bitmap _elements = new Bitmap("elements", "elements.png");
    private readonly Bitmap _floor = new Bitmap("floor", "floor.png");
    private readonly Bitmap _platform = new Bitmap("platform", "platform.png");
    private readonly Bitmap _topDecor = new Bitmap("top_decor", "top_decor.png");
    private double _elementsPosition = 0.0;
    private double _topDecorPosition = 0.0;
    public short floorPosition = 0;

    public void Move(sbyte direction)
    {
        // dont move if screen's already at the start or the end
        if (RestrictMove(direction)) return;

        floorPosition     +=  direction;
        _elementsPosition += (direction * 0.9); // bg elements is 10% slower than platform
        _topDecorPosition += (direction * 0.4); // top decor is 60% slower than platform
    }

    private bool RestrictMove(sbyte deduction)
    {
        // direction 1 is forward and 0 is backward
        if (deduction == -2) { return floorPosition == -5844; }

        return floorPosition is (0 or -5844);
    }

    public void Draw(int layerId)
    {   
        // draw all layers on the screen
        switch (layerId)
        {
            case 0: _background.Draw(0, 0); break;
            case 1: _elements.Draw(_elementsPosition, 0); break;
            case 2: _platform.Draw(floorPosition, 30); break;
            case 3: _floor.Draw(floorPosition, 30); break;
            case 4: _topDecor.Draw(_topDecorPosition, 0); break;
        }
    }

    // print data on terminal 
    public void Debug()
    {
        Console.WriteLine($"floorPosition: {floorPosition}");
    }
}