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

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            GameManager.instance.AddScore(15);
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("Player") || bullFood == (true))
        {
            GameManager.instance.AddScore(15);
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("Player")  || kangFood == (true))
        {
            GameManager.instance.AddScore(15);
            Destroy(gameObject);
        }

    }


}
