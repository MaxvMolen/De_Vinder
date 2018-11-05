using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {
    public Transform exit;
   // public Transform TeleportMe;
    public Transform Player;
    // Use this for initialization
    void Start() {
 
    }

    // Update is called once per frame
    void Update() {

    }


    public void RestartL() {
        Player.position = exit.position;
   //     TeleportMe.position = exit.position;
    }

    public void Restartlevel() {
        SceneManager.LoadScene("Mini_Game");
    }

}
