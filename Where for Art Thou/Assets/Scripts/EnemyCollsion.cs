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
        if (col.gameObject.CompareTag("Player") && gameObject.tag == ("Kangaroo"))
        {
            GameObject newFood = (GameObject)Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            newFood.GetComponent<FoodScript>().kangFood = true;
            Destroy(gameObject);
           
        }
        if (col.gameObject.CompareTag("Player") && gameObject.tag == ("Boar"))
        {
            GameObject newFood = (GameObject)Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            newFood.GetComponent<FoodScript>().boarFood = true;
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("Player") && gameObject.tag == ("Bull"))
        {
           
            GameObject newFood = (GameObject)Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            newFood.GetComponent<FoodScript>().bullFood = true;
            Destroy(gameObject);

        }

        if(col.gameObject.CompareTag("Bullet"))
        {
            Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            Destroy(gameObject);
            Destroy(col.gameObject);

        }


    }

}
