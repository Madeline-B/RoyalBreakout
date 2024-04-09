using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnlockLock : MonoBehaviour
{
    public gameScript game;

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.CompareTag("Key")) {
            Destroy(gameObject);
            game.UnlockCell();
        }
    }
}
