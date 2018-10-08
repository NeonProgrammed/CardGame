using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatureSelection : MonoBehaviour {

    public Button bugButton;
    public Button dragonButton;

    public Sprite selected;
    public Sprite deselected;

    public bool bugSelected = false;
    public bool dragonSelected = false;

    public void SelectBug()
    {
        if (!bugSelected)
        {
            bugButton.GetComponent<Image>().sprite = selected;
            dragonButton.GetComponent<Image>().sprite = deselected;

            bugSelected = true;
            dragonSelected = false;
        } else if (bugSelected)
        {
            bugButton.GetComponent<Image>().sprite = deselected;
            dragonButton.GetComponent<Image>().sprite = deselected;

            bugSelected = false;
            dragonSelected = false;
        }
    }

    public void SelectDragon()
    {
        if (!dragonSelected)
        {
            bugButton.GetComponent<Image>().sprite = deselected;
            dragonButton.GetComponent<Image>().sprite = selected;

            bugSelected = false;
            dragonSelected = true;
        } else if (dragonSelected)
        {
            bugButton.GetComponent<Image>().sprite = deselected;
            dragonButton.GetComponent<Image>().sprite = deselected;

            bugSelected = false;
            dragonSelected = false;
        }
    }
}
