using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void LoadGameData()
    {

    }

    public void OnContinueButtonClick()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
        LoadGameData();
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
