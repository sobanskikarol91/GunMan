using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Character/Settings", fileName = "CharacterData")]

public class CharacterSettings : ScriptableObject
{
    [SerializeField] float moveSpeed = 25f;
    [SerializeField] bool useAI = false;

    public float MoveSpeed { get { return moveSpeed; } }
    public bool UseAI { get { return useAI; } }
}
