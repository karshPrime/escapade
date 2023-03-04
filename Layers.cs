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
    private int _floorPosition = 0;
    private int _platformPosition = 0;
    private double _topDecorPosition = 0.0;
    private short _deduction = 0;

    public void Move(bool direction)
    {
        // dont move if screen's already at the start or the end
        if (RestrictMove(direction)) return;
        
        // direction 1 is forward and 0 is backward
        _deduction = direction ? (short)-2 : (short)2;

        _elementsPosition += (_deduction * 0.9); // bg elements is 10% slower than platform
        _floorPosition += _deduction;
        _platformPosition += _deduction;
        _topDecorPosition += (_deduction * 0.4); // top decor is 60% slower than platform
    }

    private bool RestrictMove(bool direction)
    {
        // direction 1 is forward and 0 is backward
        if (direction) { return _floorPosition == -5844; }

        return _floorPosition is (0 or -5844);
    }

    public void Draw(int layerId)
    {   
        // draw all layers on the screen
        switch (layerId)
        {
            case 0: _background.Draw(0, 0); break;
            case 1: _elements.Draw(_elementsPosition, 0); break;
            case 2: _platform.Draw(_platformPosition, 30); break;
            case 3: _floor.Draw(_floorPosition, 30); break;
            case 4: _topDecor.Draw(_topDecorPosition, 0); break;
        }
    }

    public void Debug()
    {
        Console.WriteLine(_floorPosition);
    }
}