using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenUI : MonoBehaviour
{
    public ChickenIncluder chickenIncluder;
    public ChickenSpawner spawner;

    public void SpawnChicken()
    {
        ICommand command = new ChickenSpawnCommand(spawner);
        chickenIncluder.AddCommand(command);
    }
}
