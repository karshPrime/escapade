using SplashKitSDK;

/*     _ __ ___   ___  _   _ ___  ___
 *    | '_ ` _ \ / _ \| | | / __|/ _ \
 *    | | | | | | (_) | |_| \__ |  __/
 *    |_| |_| |_|\___/ \__,_|___/\___|
 */

namespace Escapade.SrcEntities;

public class Mouse
{
    private readonly Bitmap _cursor = new Bitmap("cursor", "cursor.png");

    public void Display()
    {
        _cursor.Draw(SplashKit.MouseX(), SplashKit.MouseY());
    }
}