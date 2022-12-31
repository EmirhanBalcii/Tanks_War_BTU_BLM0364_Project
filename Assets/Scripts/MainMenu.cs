using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OnContinueButtonClick()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
        PlayerPrefs.SetInt("Continue", 1);
        
    }

    public void OnNewGameButtonClick()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    
    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
