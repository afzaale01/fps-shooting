using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor01 : MonoBehaviour
{
    public GameObject TextDisplay;
    public GameObject TheDoor;
    public float TheDistance = PlayerCasting.DistanceFromTarget;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            TextDisplay.GetComponent<Text>().text = "Press Button";
            OpenTheDoor();
        }

    }

    private void OpenTheDoor()
    {

        TheDoor.GetComponent<Animator>().SetTrigger("open");
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }
}
