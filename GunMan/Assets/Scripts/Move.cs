using UnityEngine;

public abstract class Move
{
    [SerializeField] protected float speed;
    protected abstract void Movement(ICharacterInput input);
}
