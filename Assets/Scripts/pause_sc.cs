using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pause_sc : MonoBehaviour
{

    [SerializeField]
    private GameObject pauseMenu;

    public bool gameIsPaused;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        escapeFunction();
        if (gameIsPaused)
        {
            pause();
        }
        else
        {
            resume();
        }
    }
    public void pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        AudioListener.pause = true;
    }
    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        AudioListener.pause = false;
    }
    public void escapeFunction()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Input.GetAxis("escape")==0
        {
            gameIsPaused = !gameIsPaused;
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void setGameIsPaused()
    {
        gameIsPaused = !gameIsPaused;
    }

    public void OnMainMenuButtonClicked()
    {
        SavePlayerData();
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    private void SavePlayerData()
    {
        PlayerPrefs.SetInt("Player1Lives", player1_sc.Instance.lives);
        PlayerPrefs.SetInt("Player2Lives", player2_sc.Instance.lives);
        
        PlayerPrefs.SetFloat("Player1XPosition", player1_sc.Instance.transform.position.x);
        PlayerPrefs.SetFloat("Player1YPosition", player1_sc.Instance.transform.position.y);
        PlayerPrefs.SetFloat("Player1ZPosition", player1_sc.Instance.transform.position.z);

        PlayerPrefs.SetFloat("Player2XPosition", player2_sc.Instance.transform.position.x);
        PlayerPrefs.SetFloat("Player2YPosition", player2_sc.Instance.transform.position.y);
        PlayerPrefs.SetFloat("Player2ZPosition", player2_sc.Instance.transform.position.z);

        PlayerPrefs.SetFloat("Player1XRotation", player1_sc.Instance.transform.rotation.x);
        PlayerPrefs.SetFloat("Player1YRotation", player1_sc.Instance.transform.rotation.y);
        PlayerPrefs.SetFloat("Player1ZRotation", player1_sc.Instance.transform.rotation.z);

        PlayerPrefs.SetFloat("Player2XRotation", player2_sc.Instance.transform.rotation.x);
        PlayerPrefs.SetFloat("Player2YRotation", player2_sc.Instance.transform.rotation.y);
        PlayerPrefs.SetFloat("Player2ZRotation", player2_sc.Instance.transform.rotation.z);

        PlayerPrefs.SetFloat("P1TurretX", p1turret_sc.Instance.transform.eulerAngles.x);
        PlayerPrefs.SetFloat("P1TurretY", p1turret_sc.Instance.transform.eulerAngles.y);
        PlayerPrefs.SetFloat("P1TurretZ", p1turret_sc.Instance.transform.eulerAngles.z);

        PlayerPrefs.SetFloat("P2TurretX", p2turret_sc.Instance.transform.eulerAngles.x);
        PlayerPrefs.SetFloat("P2TurretY", p2turret_sc.Instance.transform.eulerAngles.y);
        PlayerPrefs.SetFloat("P2TurretZ", p2turret_sc.Instance.transform.eulerAngles.z);

    }
}
