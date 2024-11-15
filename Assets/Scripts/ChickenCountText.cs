using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenCountText : Observer
{
    public GameObject chickenText;
    private int _chickenCount;
    private Hen _hen;


    private void Awake()
    {
        if (chickenText == null)
        {
            chickenText.SetActive(true);
            chickenText = GameObject.Find("ChickenCounter");
        }
    }

    private void Start()
    {
        chickenText = GameObject.Find("ChickenCounter");

    }

    // Update is called once per frame
    void Update()
    {
        if (chickenText != null)
        {
            chickenText.GetComponent<Text>().text = "Chicken Count:" + _chickenCount;
        }
    }

    public override void Notify(Subject subject)
    {
        _hen = subject.GetComponent<Hen>();
        _chickenCount = _hen.chickenCount;
    }
}
