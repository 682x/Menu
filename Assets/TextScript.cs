using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public int layer;

    // Start is called before the first frame update
    void Start()
    {
        if (layer != 0)
            this.GetComponent<Text>().color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enable()
    {
        this.GetComponent<Text>().color = new Color(215, 215, 215);
    }

    public void disable()
    {
        this.GetComponent<Text>().color = Color.black;
    }

    public void sliderValue(Slider slide)
    {
        this.GetComponent<Text>().text = System.Math.Round(slide.value, 2) + " m";
    }
}
