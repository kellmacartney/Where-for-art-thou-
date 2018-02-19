using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    ScoreScript scoretally;

    public void Loadlevel(string NewGamelvl)
    {
        SceneManager.LoadScene(NewGamelvl);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void EndGame(string LevelToLoad)
    {
        if(scoretally.ScoreValue >= 100)
        {
            SceneManager.LoadScene("Credits");
        }
    }

}
