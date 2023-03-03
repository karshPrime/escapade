using SplashKitSDK;

namespace escapade;

public class Mouse
{
    public readonly Bitmap cursor = new Bitmap("cursor", "cursor.png");

    public void Draw()
    {
        cursor.Draw(SplashKit.MouseX(), SplashKit.MouseY());
    }
}