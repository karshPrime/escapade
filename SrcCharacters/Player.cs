namespace Escapade.SrcCharacters;

public class Player : Characters
{
    private byte _kills;
    private bool _isJumping;
    private char _status;
    private float _fallSpeed;
    
    public Player()
        : base(200, 0, 0, "zul")
    {
        _kills = 0;
        _isJumping = false;
        _status = 'i';
        _fallSpeed = 1;
    }

    public void Jump()
    {
        // initiate jump if not already jumping
        if (!_isJumping) { _isJumping = true; }
    }

    public void Jumping()
    {
        if (_isJumping)
        {
            cordsY -= _fallSpeed;
            // update character's movement is _isJumping = true
            // end with changing _isJumping back to false
        }
    }
    
    public void Animate()
    {
        switch (_status)
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

    private float CurrentGround()
    {
        return 1.3f; // change this value. is random for now.
    }

    public override void Death()
    {
        // player loses; game over.
    }
}