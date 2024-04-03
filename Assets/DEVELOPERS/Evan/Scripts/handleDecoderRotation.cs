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
        spotlight.SetActive(isHeld);
    }

    public void isBeingHeld()
    {
        isHeld = true;
    }

    public void stopBeingHeld()
    {
        isHeld = false;
    }
}
