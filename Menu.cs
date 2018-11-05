using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public AudioClip ButtonAudio;
    AudioSource audio;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
        PlayerPrefs.DeleteAll();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGameButton()
    {
        audio.PlayOneShot(ButtonAudio, 1f);
        StartCoroutine("LoadLevelGame");
    }
    // zorgt er voor dat ie een seconde wagt voor het laden van het level zodat het geluid goed afspeelt
    IEnumerator LoadLevelGame() {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Game");
    }

    public void InstructiesGameButton()
    {
        audio.PlayOneShot(ButtonAudio, 1f);
        StartCoroutine("LoadLevelInstructies");
    }

    IEnumerator LoadLevelInstructies() {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Instructies");
    }

    public void CreditsGameButton()
    {
        audio.PlayOneShot(ButtonAudio, 1f);
        StartCoroutine("LoadLevelCredits");
    }

    IEnumerator LoadLevelCredits() {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Credits");
    }
}
