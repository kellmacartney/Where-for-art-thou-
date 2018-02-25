using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int ScoreValue = 0;
    public Text scoreText;
    public int health = 3;  
    public Text hitText;
    public float nextLevel; 
    
    
    public AudioSource BGsource;
    public AudioSource sfxSource;
    public AudioClip BackgroundMusic; 
    


    public static GameManager instance = null;
    public bool loadCredits;
    public float gameOver;
    

    //Awake is always called before any Start functions
    void Awake()
    {
        ScoreValue = 0;
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        hitText = GameObject.Find("healthText").GetComponent<Text>();

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

        if (scoreText != null)
            scoreText.text = "Score:" + ScoreValue.ToString();

       

       if (hitText != null)
       hitText.text = "Hits taken: " + health.ToString();

        if (health >= gameOver)
      {
            SceneManager.LoadScene("GameOver");
            
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

    }

    private void Start()
    {
        
    }

    
}
