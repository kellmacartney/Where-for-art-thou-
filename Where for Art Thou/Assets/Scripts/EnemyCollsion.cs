using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollsion : MonoBehaviour
{
    public GameObject FoodPreFab;
    FoodScript Score;  

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") || gameObject.tag == ("Kangaroo"))
        {
            
            Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            Destroy(gameObject);
           
        }
        if (col.gameObject.CompareTag("Player") || gameObject.tag == ("Boar"))
        {
            
            Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("Player") || gameObject.tag == ("Bull"))
        {
            
            Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            Destroy(gameObject);

        }

        if(col.gameObject.name == ("BulletPreFab"))
        {
            Destroy(gameObject);

        }


    }

}
