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
    private Rigidbody rb;
    private XRGrabInteractable interactable;
    public GameObject Door;
    private Rigidbody doorRB;
    
    void Start()
    {
        doorRB = Door.GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
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
                doorRB.constraints = RigidbodyConstraints.None;
                //SoundManager.Instance.Play(SoundType.SOLVED);
                ChangeState(LockStateType.OPEN);
                break;

            case LockStateType.OPEN:
                rb.useGravity = true;
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
