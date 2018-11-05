using UnityEngine;

public class Quiz : MonoBehaviour {

    // questions
    public GameObject Question_1_Layer;
    //public GameObject Question_2_Layer;
   // public GameObject Question_3_Layer;
    public GameObject RemQuestion;
    public GameObject Question_1;
    public GameObject Answere_1;
    public GameObject Answere_2;
    public GameObject foutGoed;
    public GameObject GoedFout;
    public GameObject Answere_1_button;
    public GameObject Answere_2_button;
    public GameObject Grey;

    public AudioClip ButtonAudio;
    AudioSource audio;

    // Use this for initialization
    void Start () {
        Question_1_Layer.SetActive(false);
        //Question_2_Layer.SetActive(false);
        //Question_3_Layer.SetActive(false);
        RemQuestion.SetActive(false);
        foutGoed.SetActive(false);
        GoedFout.SetActive(false);

        audio = GetComponent<AudioSource>();
    }   
	
	// Update is called once per frame
	void Update () {

    }

    public void Answerefout() {
        RemQuestion.SetActive(true);
        // zet de buttons uit
        Answere_1_button.SetActive(false);
        Answere_2_button.SetActive(false);
        foutGoed.SetActive(true);
        GoedFout.SetActive(false);
        Grey.SetActive(false);
        audio.PlayOneShot(ButtonAudio, 1f);
        GameObject.FindWithTag("Deur").SetActive(false);
    }

    public void Answeregoed() {
        RemQuestion.SetActive(true);
        // zet de buttons uit
        Answere_1_button.SetActive(false);
        Answere_2_button.SetActive(false);
        foutGoed.SetActive(true);
        GoedFout.SetActive(false);
        Grey.SetActive(false);
        audio.PlayOneShot(ButtonAudio, 1f);
        GameObject.FindWithTag("Deur").SetActive(false);
    }

    public void Answerefout2() {
        RemQuestion.SetActive(true);
        // zet de buttons uit
        Answere_1_button.SetActive(false);
        Answere_2_button.SetActive(false);
        foutGoed.SetActive(false);
        GoedFout.SetActive(true);
        Grey.SetActive(false);
        audio.PlayOneShot(ButtonAudio, 1f);
        GameObject.FindWithTag("Deur").SetActive(false);
    }

    public void Answeregoed2() {
        RemQuestion.SetActive(true);
        // zet de buttons uit
        Answere_1_button.SetActive(false);
        Answere_2_button.SetActive(false);
        foutGoed.SetActive(false);
        GoedFout.SetActive(true);
        Grey.SetActive(false);
        audio.PlayOneShot(ButtonAudio, 1f);
        GameObject.FindWithTag("Deur").SetActive(false);
    }

    public void RemoveQuestion() {
        Question_1_Layer.SetActive(false);
//        Question_2_Layer.SetActive(false);
       // Question_3_Layer.SetActive(false);
        RemQuestion.SetActive(false);
        foutGoed.SetActive(false);
        GoedFout.SetActive(false);
        Grey.SetActive(false);
        audio.PlayOneShot(ButtonAudio, 1f);
    }

}
