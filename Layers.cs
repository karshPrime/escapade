using SplashKitSDK;

namespace escapade;

public class Layers
{
    private readonly Bitmap _background = new Bitmap("background", "background.png"); 
    private readonly Bitmap _elements = new Bitmap("elements", "elements.png");
    private readonly Bitmap _floor = new Bitmap("floor", "floor.png");
    private readonly Bitmap _platform = new Bitmap("platform", "platform.png");
    private readonly Bitmap _topDecor = new Bitmap("top_decor", "top_decor.png");
    private double _elementsPosition = 0.0;
    private double _floorPosition = 0.0;
    private double _platformPosition = 0.0;
    private double _topDecorPosition = 0.0;
    private double _deduction = 0.0;

    public void Move(bool direction)
    {   
        // direction 1 is forward and 0 is backward
        if (direction) { _deduction = 1.0; } else { _deduction = -1.0; }

        _elementsPosition -= (_deduction * 0.6); // bg elements is 40% slower than platform
        _floorPosition    -= _deduction; 
        _platformPosition -= _deduction;
        _topDecorPosition -= (_deduction * 0.7); // top decor is 30% slower than platform
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
}