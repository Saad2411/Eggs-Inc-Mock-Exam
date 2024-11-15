using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{
    public GameObject chickenPrefab;

    public Transform _spawnLocation;
    public Transform _targetLocation;


    public void SpawnChicken()
    {
        IFactory factory = new ChickenFactory(chickenPrefab);

        GameObject product = factory.CreateProduct();

        product.transform.position = _spawnLocation.position;
    }
}
