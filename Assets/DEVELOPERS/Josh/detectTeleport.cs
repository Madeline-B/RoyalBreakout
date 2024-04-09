using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectTeleport : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        
    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("box"))
        {
            transform.position = GameObject.FindWithTag("Thrownroomtp").transform.position;
            transform.rotation = GameObject.FindWithTag("Thrownroomtp").transform.rotation;
        }
        
        //Rigidbody object = hit.collider.attachedRigidbody;
    }
}
