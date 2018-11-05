using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour {

    public GameObject HomeScreen;
    public GameObject QuitYesNo;
    
    public AudioClip ButtonAudio;
    AudioSource audio;
    // public GameObject QuitNo;

    // Use this for initialization
    void Start () {
        HomeScreen.SetActive(true);
        QuitYesNo.SetActive(false);
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HomeScreenButton()
    {
        QuitYesNo.SetActive(true);
        audio.PlayOneShot(ButtonAudio, 1f);
    }

    public void QuitGameYes()
    {
        //Application.LoadLevel("StraatBorden");
        StartCoroutine("LoadLevelMenu");
        audio.PlayOneShot(ButtonAudio, 1f);
    }

    IEnumerator LoadLevelMenu() {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("StraatBorden");
    }

    public void QuitGameNo()
    {
        QuitYesNo.SetActive(false);
        audio.PlayOneShot(ButtonAudio, 1f);
    }
    public void QuitGameMenu() {
        Application.Quit();
    }

}
