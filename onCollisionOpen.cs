using UnityEngine;

public class onCollisionOpen : MonoBehaviour {

    private Rigidbody rb;
    // als ie true is zet ie de deur op false
    private bool DeurUrn;
    public GameObject Vraag1;
    public AudioClip UrnAudio;
    //AudioSource audio;

    // Update is called once per frame
    void Update () {

	}
    
    void OnTriggerEnter2D(Collider2D other)
    {   
        // vraag 1
        if (other.gameObject.CompareTag("pick_up"))
         {   // zet de urn op false
            GameObject.FindWithTag("pick_up").SetActive(false);
  //          audio.PlayOneShot(UrnAudio, 1f);
            DeurUrn = true;
            if (DeurUrn == true)
            {
                Vraag1.SetActive(true);
            }
        }
    }
}
