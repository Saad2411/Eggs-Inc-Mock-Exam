using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenManager : Singleton<ChickenManager>
{
    public int currentChickenCount;

    public void UpdateChickenCount()
    {
        currentChickenCount++;
    }
}
