using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFactory : IFactory
{
    private GameObject _goodChickenPrefab;
    private GameObject _evilChickenPrefab;
    private float _chance;

    public ChickenFactory(GameObject goodChickenPrefab, GameObject evilChickenPrefab, float chance)
    {
        _goodChickenPrefab = goodChickenPrefab;
        _evilChickenPrefab= evilChickenPrefab;
        _chance = chance;
    }

    public GameObject CreateProduct()
    {
        float luck = Random.Range(0f, 1f);

        if (luck <= _chance)
        {
            return GameObject.Instantiate(_evilChickenPrefab);
        }
        else
        {
            return GameObject.Instantiate(_goodChickenPrefab);
        }

    }

}
