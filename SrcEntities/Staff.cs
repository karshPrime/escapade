using SplashKitSDK;

/*         _         __  __
 *     ___| |_ __ _ / _|/ _|
 *    / __| __/ _` | |_| |_
 *    \__ | || (_| |  _|  _|
 *    |___/\__\__,_|_| |_|
 */

namespace Escapade.SrcEntities;

public class Staff : Layer
{
    private float _ground;
    private bool _isShooting;
    private float[] _target = new float[2];
    private sbyte _hoverDirection;

    public Staff() : base("staff", 2)
    {
        _isShooting = false;
        _cordsX = 70;
        _cordsY = _ground = 450;
        _hoverDirection = 1;
    }

    public void Hover()
    {
        if (_cordsY + 30 <= _ground) { _hoverDirection =  1; }
        else if (_cordsY >= _ground) { _hoverDirection = -1; }

        _cordsY += _hoverDirection * 0.45f;
    }

    public void UpdateGround(float playerY)
    {
        _ground = playerY;
    }

    public void Shoot()
    {
        if (_isShooting) return;
        _target[0] = SplashKit.MouseX();
        _target[1] = SplashKit.MouseY();
        _isShooting = true;
    }

    public void Shooting()
    {
        if (_isShooting)
        {
            // perform shooting animation and attack action
            // end with making _isShooting = false;
        }
    }
}
