using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    public bool boarFood, bullFood, kangFood;
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
        if (col.gameObject.CompareTag("Player") || boarFood == (true))
        {
            print("yeet");
            GameManager.instance.AddScore(15);
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("Player") || bullFood == (true))
        {
            print("yeet");
            GameManager.instance.AddScore(15);
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("Player")  || kangFood == (true))
        {
            print("yeet");
            GameManager.instance.AddScore(15);
            Destroy(gameObject);
        }

    }


}
