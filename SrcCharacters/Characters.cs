using System.Xml.Linq;
using SplashKitSDK;

/*            _                          _
 *        ___| |__   __ _ _ __ __ _  ___| |_ ___ _ __ ___
 *      / __| '_ \ / _` | '__/ _` |/ __| __/ _ | '__/ __|
 *     | (__| | | | (_| | | | (_| | (__| ||  __| |  \__ \
 *      \___|_| |_|\__,_|_|  \__,_|\___|\__\___|_|  |___/
 */

namespace escapade.SrcCharacters;

public class Characters
{
    protected Bitmap _character;
    protected byte _health;
    protected bool _isHurt;
    public short cordsX;
    public short cordsY;

    protected Characters(byte health, short startX, short startY, string name)
    {
        _character = new Bitmap(name, $"{name}.png");
        _health = health;
        _isHurt = false;
        cordsX = startX;
        cordsY = startY;
    }

    public void Animate(char action)
    {
        switch (action)
        {
            // instead of printing name of the action; trigger a method for it.
            case 'a': Console.WriteLine("attack"); break;
            case 'b': Console.WriteLine("backward"); break;
            case 'f': Console.WriteLine("forward"); break;
            case 'i': Console.WriteLine("idle"); break;
            case 'j': Console.WriteLine("jump"); break;
            case 'h': Console.WriteLine("hurt"); break;
        }
    }

    // decrease character's health
    public void GetHurt(byte damage)
    {
        _health -= damage;
        if (_health <= 0) {Death();}
    }

    // character death effect
    private void Death()
    {
        // poof
    }

    public void Display()
    {
        // update this function with animation support
        _character.Draw(cordsX, cordsY);
        
        // add blood effect if _isHurt = true
    }
}