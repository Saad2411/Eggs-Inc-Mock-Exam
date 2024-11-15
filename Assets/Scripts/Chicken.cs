using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Chicken : MonoBehaviour
{
    public Rigidbody rb;
    private ChickenSpawner spawner;
    public float speed;

    private ChickenCountText _countText;


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
        MoveToDestination();
    }

    void MoveToDestination()
    {
        float velocity = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, spawner._targetLocation.position, velocity);
    }
}
