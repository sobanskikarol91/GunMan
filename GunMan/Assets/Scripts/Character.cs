using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
    [SerializeField] CharacterSettings settings;
    ICharacterInput input;
    PlayerMovement movement;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        input = settings.UseAI ? new PlayerInput() as ICharacterInput : new EnemyInput();
    }

    void Update()
    {
        input.ReadInput();
    }
}
