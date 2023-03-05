using SplashKitSDK;

/*     _
 *    | | __ _ _   _  ___ _ __ ___
 *    | |/ _` | | | |/ _ | '__/ __|
 *    | | (_| | |_| |  __| |  \__ \
 *    |_|\__,_|\__, |\___|_|  |___/
 *             |___/
 */

namespace Escapade.SrcEntities;

public class Layer
{
    private Bitmap _layer;
    private float _speed;
    private float _xCord;

    public Layer(string name, float speed)
    {
        _layer = new Bitmap(name, $"{name}.png");
        _speed = speed;
        _xCord = 0;
    }

    public void Forward()
    {
        _xCord -= _speed;
    }

    public void Backward()
    {
        _xCord += _speed;
    }

    public void Display()
    {
        _layer.Draw(_xCord, 0);
    }
}