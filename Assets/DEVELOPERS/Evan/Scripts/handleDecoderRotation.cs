using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handleDecoderRotation : MonoBehaviour
{
    public bool isHeld;
    public GameObject spotlight;

    // Update is called once per frame
    void Update()
    {

    }

    public void isBeingHeld()
    {
        isHeld = true;
        spotlight.SetActive(true);
    }

    public void stopBeingHeld()
    {
        isHeld = false;
        spotlight.SetActive(false);
    }
}
