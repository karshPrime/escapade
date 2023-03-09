using System.Xml.Linq;
using SplashKitSDK;

/*            _                          _
 *        ___| |__   __ _ _ __ __ _  ___| |_ ___ _ __ ___
 *      / __| '_ \ / _` | '__/ _` |/ __| __/ _ | '__/ __|
 *     | (__| | | | (_| | | | (_| | (__| ||  __| |  \__ \
 *      \___|_| |_|\__,_|_|  \__,_|\___|\__\___|_|  |___/
 */

namespace Escapade.SrcCharacters;

public class Characters
{
    protected Bitmap _character;
    protected byte _health;
    protected bool _isHurt;
    protected float _cordsX;
    protected float _cordsY;

    protected Characters(byte health, float startX, float startY, string name)
    {
        _character = new Bitmap(name, $"{name}.png");
        _health = health;
        _isHurt = false;
        _cordsX = startX;
        _cordsY = startY;
    }

    // decrease character's health
    public void GetHurt(byte damage)
    {
        _health -= damage;
        if (_health <= 0) {Death();}
    }

    // character death effect
    public virtual void Death() {  } // different for different entities

    public void Display()
    {
        // update this function with animation support
        _character.Draw(cordsX, cordsY);
        
        // add blood effect if _isHurt = true
    }
}
