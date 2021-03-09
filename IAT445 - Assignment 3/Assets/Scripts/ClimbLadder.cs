using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ClimbLadder : MonoBehaviour
{
    public Transform playerController;
    bool insideLadder = false;
    public float ladderFactor = 5.5f;
    public FirstPersonController playerInput;

    void Start()
    {
        playerInput = GetComponent<FirstPersonController>();
        insideLadder = false;
    }

    //Detects if character enters the ladder box collider
    private void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Ladder"){
            playerInput.enabled = false;
            insideLadder = !insideLadder;
        }
    }

    //Detects if character exits the ladder box collider
    private void OnTriggerExit(Collider col){
        if(col.gameObject.tag == "Ladder"){
            playerInput.enabled = true;
            insideLadder = !insideLadder;
        }
    }

    void Update(){
        //Move the character up when 'w' is pressed
        if(insideLadder && Input.GetKey("w")){
            playerController.transform.position += Vector3.up / ladderFactor;
        }
        //Move the character down when 's' is pressed
        if(insideLadder && Input.GetKey("s")){
            playerController.transform.position += Vector3.down / ladderFactor;
        }
    }
}
