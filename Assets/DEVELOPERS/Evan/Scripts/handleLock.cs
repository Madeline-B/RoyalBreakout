using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handleLock : MonoBehaviour
{
    public gameScript game;

    public Transform dial1;
    public int dial1Value = 1;
    private int dial1Combination = 6;

    public Transform dial2;
    public int dial2Value = 1;
    private int dial2Combination = 1;

    public Transform dial3;
    public int dial3Value = 1;
    private int dial3Combination = 3;

    public GameObject blockingDoor;


    bool firstTimeUnlocked = true;

    private void Update()
    {
        if (blockingDoor.active && checkDials())
        {
            blockingDoor.SetActive(false);
        }
    }

    public void rotateDial1()
    {
        dial1.Rotate(Vector3.up, -60f);
        dial1Value += 1;

        if (dial1Value > 6)
            dial1Value = 1;
    }

    public void rotateDial2()
    {
        dial2.Rotate(Vector3.up, -60f);
        dial2Value += 1;

        if (dial2Value > 6)
            dial2Value = 1;
    }

    public void rotateDial3()
    {
        dial3.Rotate(Vector3.up, -60f);
        dial3Value += 1;

        if (dial3Value > 6)
            dial3Value = 1;
    }

    public bool checkDials()
    {
        if (dial1Value == dial1Combination && dial2Value == dial2Combination && dial3Value == dial3Combination)
        {
            if (firstTimeUnlocked)
            {
                firstTimeUnlocked = false;
                game.lockSolved = true;
            }
            return true;
        }
        return false;
    }
}
