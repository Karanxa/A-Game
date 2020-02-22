using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelNumber : MonoBehaviour
{
    public Text text;
    int sceneIndex;

    void Start()
    {
        text = GetComponent<Text>();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {
        text.text = "Level " + sceneIndex;
    }
	
}
