using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Transform player;
    public Text scoreText;
    public Text highScore;
    // Update is called once per frame
    public void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }



    void Update ()
    {
        int number = (int)player.position.z;
        scoreText.text = number.ToString();
        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = number.ToString();
        }
	}
}
