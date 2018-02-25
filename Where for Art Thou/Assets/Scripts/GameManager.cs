using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int ScoreValue = 0;
    public Text scoreText;
    public int health = 0;  
    public Text hitText;
    public float nextLevel;
    public bool inGameOver;
    
    
    public AudioSource BGsource;
    public AudioSource sfxSource;
    public AudioClip BackgroundMusic; 
    


    public static GameManager instance = null;
    public bool loadCredits;
    public float gameOver;
    

    //Awake is always called before any Start functions
    void Awake()
    {
        //InitLevel();

        // Destroy(SoundManager.instance);

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
        if (ScoreValue >= nextLevel && !loadCredits)
        {
            loadCredits = true;
            SceneManager.LoadScene("Credits");
        }


        if ( !inGameOver && health >= gameOver)
      {
            SceneManager.LoadScene("GameOver");
            inGameOver = true;
            loadCredits = false;
            
      }
    }

    public void PlayOneShot(AudioClip Clip)
    {
        BGsource.clip = Clip;
        BGsource.Play();
    }

    public void AddScore(int points)
    {
        ScoreValue += points;
        UpdateTextObjects();
    }

    public void AddHP(int points)
    {
        health += points;
        UpdateTextObjects();
    }

    public void UpdateTextObjects()
    {
        scoreText.text = "Score:" + ScoreValue;
        hitText.text = "Hits taken: " + health;
    }


    private void Start()
    {
        
    }

    public void InitLevel()
    {
        inGameOver = false; 
        ResetScore();
        AssignTextObjects();
        UpdateTextObjects();
        Debug.Log("Level Init");

    }

    public void ResetScore()
    {
        ScoreValue = 0;
        health = 0;
    }

    public void AssignTextObjects()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        hitText = GameObject.Find("healthText").GetComponent<Text>();
    }

}
