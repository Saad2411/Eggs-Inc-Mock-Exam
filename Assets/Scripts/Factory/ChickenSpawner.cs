using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{
    public GameObject goodChickenPrefab;
    public GameObject evilChickenPrefab;
    public float evilChickenChance;

    public Transform _spawnLocation;
    public Transform _targetLocation;


    public void SpawnChicken()
    {
        IFactory factory = new ChickenFactory(goodChickenPrefab, evilChickenPrefab, evilChickenChance);

        GameObject product = factory.CreateProduct();

        product.transform.position = _spawnLocation.position;
    }
}
