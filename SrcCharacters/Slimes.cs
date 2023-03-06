namespace Escapade.SrcCharacters;

/*         _ _
 *     ___| (_)_ __ ___   ___ ___
 *    / __| | | '_ ` _ \ / _ / __|
 *    \__ | | | | | | | |  __\__ \
 *    |___|_|_|_| |_| |_|\___|___/
 */

public class Slimes : Characters
{
    public Slimes(short startX, short startY) 
        : base(1, startX, startY, "slime") {}

    public void Bounce()
    {
        // slimes bounce to walk; add that effect
    }
    
    public override void Death()
    {
        // poof the slime
    }
}
