using UnityEngine;
using UnityEngine.SceneManagement;

public class teleporter : MonoBehaviour {
   // public Transform exit;
   // public Transform TeleportMe;
    public string level = "Level2";

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("PlayerChar")) {

            SceneManager.LoadScene(level);
            //TeleportMe.position = exit.position;
           
        }
    }
}
