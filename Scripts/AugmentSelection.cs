using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AugmentSelection : MonoBehaviour {
    public Button redAugment;
    public Button blueAugment;
    public Button purpleAugment;

    public Sprite selected;
    public Sprite deselected;

    public bool redSelected;
    public bool blueSelected;
    public bool purpleSelected;

    public void SelectRed()
    {
        if (!redSelected)
        {
            redAugment.GetComponent<Image>().sprite = selected;
            blueAugment.GetComponent<Image>().sprite = deselected;
            purpleAugment.GetComponent<Image>().sprite = deselected;
            redSelected = true;
            blueSelected = false;
            purpleSelected = false;
        } else if (redSelected)
        {
            redAugment.GetComponent<Image>().sprite = deselected;
            redSelected = false;
            blueSelected = false;
            purpleSelected = false;
        }
    }

    public void SelectBlue()
    {
        if (!blueSelected)
        {
            redAugment.GetComponent<Image>().sprite = deselected;
            blueAugment.GetComponent<Image>().sprite = selected;
            purpleAugment.GetComponent<Image>().sprite = deselected;
            redSelected = false;
            blueSelected = true;
            purpleSelected = false;
        }
        else if (blueSelected)
        {
            blueAugment.GetComponent<Image>().sprite = deselected;
            redSelected = false;
            blueSelected = false;
            purpleSelected = false;
        }
    }

    public void SelectPurple()
    {
        if (!purpleSelected)
        {
            redAugment.GetComponent<Image>().sprite = deselected;
            blueAugment.GetComponent<Image>().sprite = deselected;
            purpleAugment.GetComponent<Image>().sprite = selected;
            redSelected = false;
            blueSelected = false;
            purpleSelected = true;
        }
        else if (purpleSelected)
        {
            purpleAugment.GetComponent<Image>().sprite = deselected;
            redSelected = false;
            blueSelected = false;
            purpleSelected = false;
        }
    }
}
