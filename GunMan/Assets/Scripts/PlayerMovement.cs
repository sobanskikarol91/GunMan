using UnityEngine;
using System.Collections;

public class PlayerMovement : ICharacterMovement
{
    ICharacterInput input;
    CharacterSettings settings;
    Rigidbody2D rb;

    public PlayerMovement(Rigidbody2D rb, ICharacterInput input, CharacterSettings settings)
    {
        this.settings = settings;
        this.input = input;
        this.rb = rb;
    }

    public void Movement()
    {
        if (input.Horizontal == 0) return;
        rb.AddForce(input.Horizontal * settings.MoveSpeed * Vector2.right);
    }
}
