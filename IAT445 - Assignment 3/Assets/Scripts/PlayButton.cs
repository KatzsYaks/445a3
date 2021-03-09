using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    //Load Castle Outdoors Scene
    public void PlayGame(){
        SceneManager.LoadScene("MiltonScene1");
    }
}
