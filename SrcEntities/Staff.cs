using SplashKitSDK;

namespace Escapade.SrcEntities;

public class Staff : Layer
{
    private float _ground;
    private bool _isShooting;
    private float[] _target = new float[2];

    public Staff() : base("staff", 2)
    {
        _isShooting = false;
    }

    public void Hover()
    {
        // update staff's _cordsY for bounce on _ground
    }

    public void UpdateGround(float playerY)
    {
        _ground = playerY;
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
