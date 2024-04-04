using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.XR.Interaction.Toolkit;

public class handleHolding : MonoBehaviour
{
    public bool isHeld;


    // Update is called once per frame
    void Update()
    {
        
    }

    public void isBeingHeld()
    {
        isHeld = true;
        print("SDJIUOASHJDUISAHJDUIO");
    }

    public void stopBeingHeld()
    {
        isHeld = false;
    }
}
