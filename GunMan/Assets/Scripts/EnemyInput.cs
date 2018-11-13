using UnityEngine;
using System.Collections;

public class EnemyInput : ICharacterInput 
{
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }

    public void ReadInput()
    {
        throw new System.NotImplementedException();
    }
}
