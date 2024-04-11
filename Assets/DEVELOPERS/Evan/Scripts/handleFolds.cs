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
    bool first = false;


    void Update()
    {
        if (!first)
        {
            if (Time.time - timeOfGrab > 11f && isHeld)
            {
                ChangeModel();
                timeOfGrab = Time.time;
                first = true;
            }
        }
        else
        {
            if (Time.time - timeOfGrab > 1.5f && isHeld)
            {
                ChangeModel();
                timeOfGrab = Time.time;
            }
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
