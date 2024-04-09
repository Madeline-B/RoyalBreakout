using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameScript : MonoBehaviour
{
    public bool cellUnlocked = false;
    public bool lockSolved = false;
    public bool inDungeonRoom = false;

    public GameObject dungeonTeleportArea;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UnlockCell()
    {
        cellUnlocked = true;

        print("You can now teleport");
        dungeonTeleportArea.SetActive(true);
    }
}
