using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>().ResetGame();        
    }
     
    public void LoadGameOver()
    {
        StartCoroutine(LevelDelay());
    }

    IEnumerator LevelDelay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Start Menu"); // Actually is Game Over. Rename cannot be done at present.      
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
