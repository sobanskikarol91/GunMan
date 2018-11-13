using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
    [SerializeField] CharacterSettings settings;
    ICharacterInput input;
    ICharacterMovement movement;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        input = settings.UseAI ? new EnemyInput() as ICharacterInput : new PlayerInput();
        movement = settings.UseAI ? new EnemyMovement() : new PlayerMovement(rb, input, settings) as ICharacterMovement;
    }

    void Update()
    {
        input.ReadInput();
        movement.Movement();
    }
}
