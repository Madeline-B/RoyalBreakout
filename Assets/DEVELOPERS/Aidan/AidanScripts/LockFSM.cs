using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public enum LockStateType {
    CLOSED,
    OPENING,
    OPEN
}

public class LockFSM : MonoBehaviour
{
    public LockStateType State { get; private set; }
    private Animator animator;
    private Rigidbody lockrb;
    private XRGrabInteractable interactable;
    public GameObject Door;
    private Rigidbody doorRB;

    public gameScript game;
    
    void Start()
    {
        doorRB = Door.GetComponent<Rigidbody>();
        lockrb = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
        State = LockStateType.CLOSED;
        interactable = GetComponent<XRGrabInteractable>();
    }

    void Update()
    {
        switch (State) {
            case LockStateType.CLOSED:
                break;

            case LockStateType.OPENING:
                animator.Play("LockUnlock");
                lockrb.constraints = RigidbodyConstraints.None;
                doorRB.constraints = RigidbodyConstraints.None;
                soundManager.Instance.Play(SoundType.LOCKSOLVED);
                ChangeState(LockStateType.OPEN);
                game.UnlockCell();
                break;

            case LockStateType.OPEN:
                lockrb.useGravity = true;
                interactable.enabled = true;
                break;
        }
    }

    public void ChangeState (LockStateType newState) {
        State = newState;
    }

    private void OnCollisionEnter(Collision collision) {
        print(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Key") && State == LockStateType.CLOSED) {
            ChangeState(LockStateType.OPENING);
        }
    }
}
