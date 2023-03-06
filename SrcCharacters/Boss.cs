namespace Escapade.SrcCharacters;
/*      _
 *     | |__   ___  ___ ___
 *     | '_ \ / _ \/ __/ __|
 *     | |_) | (_) \__ \__ \
 *     |_.__/ \___/|___|___/
 */          
public class Boss : Characters
{
    private bool _spawn;

    public Boss()
        : base(250, 0, 0, "boss")
    {
        _spawn = false; // will spawn only when player reaches end of the map
    }

    public void Bounce()
    {
        // boss will bounce on its location; add that effect
    }

    public void Attack()
    {
        // boss attacks
    }
    
    public override void Death()
    {
        // player wins; game over.
    }
}
