using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameScript : MonoBehaviour
{
    // booleans for states of multiple puzzles throughout the escape room
    public bool cellUnlocked = false;
    public bool lockSolved = false;
    public bool inThroneRoom = false;
    public bool gemPuzzleSolved = false;
    public bool chessPuzzleSolved = false;
    public bool decoderMade = false;

    // The teleport area object in the dungeon
    public GameObject dungeonTeleportArea;
    public GameObject victory;

    float timeOfStart;

    // Start is called before the first frame update
    void Start()
    {
        timeOfStart = Time.time;
    }

    void Update()
    {
        if (decoderMade && gemPuzzleSolved)
        {
            print("!!!");
            victory.SetActive(true);
        }    
    }

    public void UnlockCell()
    {
        cellUnlocked = true;

        print("You can now teleport");
        dungeonTeleportArea.SetActive(true);
    }

    public void finishChess()
    {
        chessPuzzleSolved = true;
    }
}
