using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    public bool boarFood, bullFood, kangFood;
    public AudioClip collected; 
    //ScoreScript points; 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") && boarFood == (true))
        {
            GameManager.instance.sfxSource.PlayOneShot(collected);
            GameManager.instance.AddScore(15);
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("Player") && bullFood == (true))
        {
            GameManager.instance.sfxSource.PlayOneShot(collected);
            GameManager.instance.AddScore(20);
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("Player") && kangFood == (true))
        {
            GameManager.instance.sfxSource.PlayOneShot(collected);
            GameManager.instance.AddScore(30);
            Destroy(gameObject);
        }

    }


}
