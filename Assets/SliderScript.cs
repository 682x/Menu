using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public int layer;

    // Start is called before the first frame update
    void Start()
    {
        if (layer != 0)
            this.GetComponent<Selectable>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enable()
    {
        this.GetComponent<Selectable>().interactable = true;
    }

    public void disable()
    {
        this.GetComponent<Selectable>().interactable = false;
    }
}
