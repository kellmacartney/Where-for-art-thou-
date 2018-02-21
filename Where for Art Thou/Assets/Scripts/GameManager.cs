using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int ScoreValue = 0;
    public Text scoreText;

    public static GameManager instance = null;

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
        scoreText.text = "Score:" + ScoreValue.ToString();
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