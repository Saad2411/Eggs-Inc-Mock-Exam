using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfitManager : Singleton<ChickenManager>
{
    public float profitRate;
    public float currentProfit;

    public Text profitText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ProfitMaker());
    }

    // Update is called once per frame
    void Update()
    {
        if (profitText != null)
        {
            profitText.text = "Profit:" + currentProfit;
        }
    }

    private IEnumerator ProfitMaker()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            currentProfit += profitRate * ChickenManager.Instance.currentChickenCount;
        }
    }
}
