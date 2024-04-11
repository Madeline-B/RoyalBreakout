using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CheckSockets : MonoBehaviour
{
    AudioSource breaksound;
    public XRSocketInteractor SocketBlue;
    public XRSocketInteractor SocketRed;
    public XRSocketInteractor SocketPurple;
    public XRSocketInteractor SocketGreen;
    public XRSocketInteractor SocketYellow;
    public GameObject hiddenWall;

    public gameScript game;

    bool isBlueCorrect;
    bool isRedCorrect;
    bool isPurpleCorrect;
    bool isGreenCorrect;
    bool isYellowCorrect;

    public void Start(){
        isBlueCorrect = false;
        isRedCorrect = false;
        isPurpleCorrect = false;
        isGreenCorrect = false;
        isYellowCorrect = false;
    }


    //this function is linked to each of the sockets and is called onces something sockted in, each time something is socketed
    //it checks the whole socket arangment of the item in the socket, if it has matching tags its correct bool is set to true
    //when they are all correct the last if statment is checked and activates puzzel completion
    public void checkSocket(){
        IXRSelectInteractable blue = SocketBlue.GetOldestInteractableSelected();
        IXRSelectInteractable red = SocketRed.GetOldestInteractableSelected();
        IXRSelectInteractable purple = SocketPurple.GetOldestInteractableSelected();
        IXRSelectInteractable green = SocketGreen.GetOldestInteractableSelected();
        IXRSelectInteractable yellow = SocketYellow.GetOldestInteractableSelected();
 
        if(blue != null && blue.transform.CompareTag("Blue") ){
            Debug.Log(blue.transform.tag + " in socket of " + transform.tag);
            isBlueCorrect = true;
        }else isBlueCorrect = false;
        if (red!= null && red.transform.CompareTag("Red")){
            Debug.Log(red.transform.tag + " in socket of " + transform.tag);
            isRedCorrect = true;
        }else isRedCorrect = false;
        if (purple != null && purple.transform.CompareTag("Purple")){
            Debug.Log(purple.transform.tag + " in socket of " + transform.tag);
            isPurpleCorrect = true;
        }else isPurpleCorrect= false;
        if (green!=null && green.transform.CompareTag("Green")){
            Debug.Log(green.transform.tag + " in socket of " + transform.tag);
            isGreenCorrect = true;
        }else isGreenCorrect = false;
        if (yellow!=null && yellow.transform.CompareTag("Yellow")){
            Debug.Log(yellow.transform.tag + " in socket of " + transform.tag);
            isYellowCorrect = true;
        }else isYellowCorrect = false;

        //each time an item is socketed is checks every socket
        if(isBlueCorrect && isRedCorrect && isPurpleCorrect && isGreenCorrect && isYellowCorrect){
            print("puzzel complete");
            game.gemPuzzleSolved = true;
            Destroy(hiddenWall);
        }
        



    }



}
