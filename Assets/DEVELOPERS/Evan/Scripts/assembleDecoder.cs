using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assembleDecoder : MonoBehaviour
{
    public bool piece1In;
    public bool piece2In;
    public bool piece3In;

    public bool partBuilt;
    public GameObject[] pieces;
    public GameObject decoderObject;

    public gameScript game;

    // Update is called once per frame
    void Update()
    {
        checkForDecoderAssembly();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "piece1")
            piece1In = true;
        if (collision.transform.tag == "piece2")
            piece2In = true;
        if (collision.transform.tag == "piece3")
            piece3In = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "piece1")
            piece1In = false;
        if (collision.transform.tag == "piece2")
            piece2In = false;
        if (collision.transform.tag == "piece3")
            piece3In = false;
    }

    void checkForDecoderAssembly()
    {
        if (piece1In && piece2In && piece3In)
        {
            piece1In = false; piece2In = false; piece3In = false;
            partBuilt = true;
            game.decoderMade = true;

            decoderObject.SetActive(true);

            foreach (GameObject each in pieces)
            {
                each.SetActive(false);
            }
        }
    }
}
