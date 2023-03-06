namespace Escapade.SrcCharacters;

public class Player : Characters
{
    private byte _kills;
    private bool _isJumping;
    private float _fallSpeed;
    
    public Player()
        : base(200, 0, 0, "zul")
    {
        _kills = 0;
        _isJumping = false;
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

    private float CurrentGround()
    {
        return 1.3f; // change this value. is random for now.
    }

    public override void Death()
    {
        // player loses; game over.
    }
}