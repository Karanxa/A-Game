using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
   