using SplashKitSDK;

namespace escapade;

public class Mouse
{
    private readonly Bitmap _cursor = new Bitmap("cursor", "cursor.png");

    public void Draw()
    {
        _cursor.Draw(SplashKit.MouseX(), SplashKit.MouseY());
    }
}