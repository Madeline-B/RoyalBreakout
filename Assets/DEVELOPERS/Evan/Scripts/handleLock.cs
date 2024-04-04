using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handleLock : MonoBehaviour
{
    public Transform dial1;
    public int dial1Value = 1;

    public Transform dial2;
    public int dial2Value = 1;

    public Transform dial3;
    public int dial3Value = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
