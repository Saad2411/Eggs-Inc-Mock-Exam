using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Chicken : MonoBehaviour
{
    public Rigidbody rb;
    private ChickenSpawner spawner;

    [SerializeField] private ChickenSO chickenData;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawner = FindAnyObjectByType<ChickenSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (chickenData.IsEvil)
        {
            MoveToChicken();
        }
        else
        {
            MoveToDestination();
        }
        
    }

    void MoveToDestination()
    {
        float velocity = chickenData.ChickenSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, spawner._targetLocation.position, velocity);
    }

    void MoveToChicken()
    {
        Chicken[] chickens = FindObjectsOfType<Chicken>();

        Chicken nearestChicken = null;
        float nearestDist = Mathf.Infinity;

        foreach (Chicken chicken in chickens)
        {
            if(chicken == this) continue;

            float dist = Vector3.Distance(transform.position, chicken.transform.position);
            if (dist < nearestDist)
            {
                nearestDist = dist;
                nearestChicken = chicken;
            }
        }

        if (nearestChicken != null && !nearestChicken.chickenData.IsEvil)
        {
            float velocity = chickenData.ChickenSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, nearestChicken.transform.position, velocity);
        }

    }
}
