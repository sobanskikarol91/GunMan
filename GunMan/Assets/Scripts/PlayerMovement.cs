using UnityEngine;
using System.Collections;

public class PlayerMovement : Move
{
    [SerializeField] float speed;

    Rigidbody2D rb;

    public PlayerMovement(Rigidbody2D rb)
    {
        this.rb = rb;
    }

    protected override void Movement(ICharacterInput input)
    {
        if (input.Horizontal == 0) return;
        rb.AddForce(input.Horizontal * speed * Vector2.one);
    }
}
