using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollsion : MonoBehaviour
{
    public GameObject FoodPreFab;
    public FoodScript Score;  

	// Use this for initialization
	void Start ()
    {
        Score = GetComponent<FoodScript>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") || gameObject.tag == ("Kangaroo"))
        {
            Score.kangFood = true;
            Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            Destroy(gameObject);
           
        }
        if (col.gameObject.CompareTag("Player") || gameObject.tag == ("Boar"))
        {
            Score.boarFood = true;
            Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("Player") || gameObject.tag == ("Bull"))
        {
            Score.bullFood = true;
            Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            Destroy(gameObject);

        }

        if(col.gameObject.name == ("BulletPreFab"))
        {
            Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            Destroy(gameObject);

        }


    }

}
