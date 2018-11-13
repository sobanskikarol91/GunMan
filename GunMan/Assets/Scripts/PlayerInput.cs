using UnityEngine;
using System.Collections;

public class PlayerInput : ICharacterInput
{
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }

    public void ReadInput()
    {
        Horizontal = Input.GetAxis("horizonral");
        Vertical = Input.GetAxis("vertical");
    }
}
