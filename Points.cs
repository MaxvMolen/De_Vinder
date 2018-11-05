using UnityEngine.UI;
using UnityEngine;

public class Points : MonoBehaviour {

    public GameObject scoreText;
    static int score = 0;
    static int AddScore = 10;

    // Use this for initialization
    void Start () {
        score = PlayerPrefs.GetInt("ScoreAmount");
        UpdateScore();
    }

    public void Score() {
        score += AddScore;
        PlayerPrefs.SetInt("ScoreAmount", score);
        PlayerPrefs.Save();
        UpdateScore();
       
    }

    public void UpdateScore() {
        scoreText.GetComponent<Text>().text = "" + score;
    }
}
