using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenManager : Singleton<ChickenManager>
{
    public int currentChickenCount;

    public int UpdateChickenCount()
    {
        return currentChickenCount++;
    }
}
