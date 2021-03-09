using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollision : MonoBehaviour
{

    public AudioSource source;

    void OnCollisionEnter(Collision col){
        if(col.relativeVelocity.magnitude > 0.4){
            source.Play();
        }
    }
}
