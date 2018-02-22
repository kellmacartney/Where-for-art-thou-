using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public int ScoreValue = 0;
    public Text scoreText;

    public static GameManager instance = null;
    public bool loadCredits;

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

    }

    private void Update()
    {
        if(scoreText != null)    
        scoreText.text = "Score:" + ScoreValue.ToString();

        if (ScoreValue >= 50f && !loadCredits)
        {
            loadCredits = true;
            SceneManager.LoadScene("Credits");
        }
    }

    public void AddScore(int points)
    {
        ScoreValue += points;
       
    }

    private void Start()
    {
        
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

}