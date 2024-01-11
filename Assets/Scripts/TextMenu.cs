using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TextMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        PlayerPrefs.DeleteAll();
    }   
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
