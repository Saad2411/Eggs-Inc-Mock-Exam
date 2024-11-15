using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawnCommand : ICommand
{

    private ChickenSpawner _spawner;

    public ChickenSpawnCommand(ChickenSpawner spawner)
    {
        _spawner = spawner;
    }

    public void Execute()
    {
        _spawner.SpawnChicken();
    }

    public void Undo()
    {
        throw new System.NotImplementedException();
    }
}
