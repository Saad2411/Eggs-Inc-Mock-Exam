using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChickenData", menuName = "ScriptableObjects/ChickenData", order = 2)]

public class ChickenSO : ScriptableObject
{
    [field: Header("Chicken Properties")]
    [field: SerializeField] public bool IsEvil { get; private set; }
    [field: SerializeField] public float ChickenSpeed { get; private set; }

}
