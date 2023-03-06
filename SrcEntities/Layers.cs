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
    protected Bitmap _layer;
    protected float _speed;
    protected float _cordsX;
    protected float _cordsY;

    public Layer(string name, float speed)
    {
        _layer = new Bitmap(name, $"{name}.png");
        _speed = speed;
        _cordsX = 0;
        _cordsY = 0;
    }

    public void Forward()
    {
        _cordsX -= _speed;
    }

    public void Backward()
    {
        _cordsX += _speed;
    }

    public void Display()
    {
        _layer.Draw(_cordsX, _cordsY);
    }
}