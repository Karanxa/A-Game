using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Start()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
