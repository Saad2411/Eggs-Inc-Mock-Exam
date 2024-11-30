using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : Subject
{
    private ChickenCountText _countText;
    public int chickenCount;

    private void Awake()
    {
        _countText = (ChickenCountText)FindObjectOfType(typeof(ChickenCountText));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Chicken>(out Chicken chicken))
        {
            chickenCount = ChickenManager.Instance.UpdateChickenCount();
            Destroy(chicken.gameObject);
        }
    }

    private void OnEnable()
    {
        Attach(_countText);
    }

    private void OnDisable()
    {
        Detach(_countText);
    }

    private void Update()
    {
        NotifyObservers();
    }
}
