using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public int layer;
    public bool chosen;

    // Start is called before the first frame update
    void Start()
    {
        if (layer != 0)
            this.GetComponent<Selectable>().interactable = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (chosen == true)
            this.GetComponent<Button>().Select();
    }

    public void enable()
    {
        this.GetComponent<Selectable>().interactable = true;
    }

    public void disable()
    {
        this.GetComponent<Selectable>().interactable = false;
    }

    public void choose()
    {
        chosen = true;
    }

    public void unchoose()
    {
        chosen = false;
    }

    public void keepSelected()
    {
        if (chosen == true)
            this.GetComponent<Button>().Select();
    }
}
