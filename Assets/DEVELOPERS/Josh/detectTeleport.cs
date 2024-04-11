using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectTeleport : MonoBehaviour
{
    public GameObject player;
    public gameScript game;

    private void Start()
    {
        
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (game.lockSolved && hit.gameObject.CompareTag("box"))
        {
            game.inDungeonRoom = true;
            transform.position = GameObject.FindWithTag("Thrownroomtp").transform.position;
            transform.rotation = GameObject.FindWithTag("Thrownroomtp").transform.rotation;
        }
        
        //Rigidbody object = hit.collider.attachedRigidbody;
    }
}
