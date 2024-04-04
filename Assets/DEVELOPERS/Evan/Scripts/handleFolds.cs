using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR.Management;
using UnityEngine;

public class handleFolds : MonoBehaviour
{
    public bool isHeld;
    public GameObject[] models;

    private int currentIndex = 0;
    private float timeOfGrab = 0f;


    void Update()
    {
        if (Time.time - timeOfGrab > 2f && isHeld)
        {
            ChangeModel();
            timeOfGrab = Time.time;
        }    
    }

    public void isBeingHeld()
    {
        isHeld = true;
        timeOfGrab = Time.time;
    }

    public void stopBeingHeld()
    {
        isHeld = false;
    }

    public void ChangeModel()
    {
        if (currentIndex < models.Length - 1)
        {
            models[currentIndex].SetActive(false);
            currentIndex++;
            models[currentIndex].SetActive(true);
        }
    }
}
