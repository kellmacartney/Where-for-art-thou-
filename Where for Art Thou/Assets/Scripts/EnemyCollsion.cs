using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollsion : MonoBehaviour
{
    public GameObject FoodPreFab;
    public FoodScript Score;
    public AudioClip KangarooDeath;
    public AudioClip BoarDeath;
    public AudioClip BullDeath;
    public AudioClip Bullet; 

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
            SoundManager.instance.PlayOneShot(KangarooDeath);
            GameObject newFood = (GameObject)Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            newFood.GetComponent<FoodScript>().kangFood = true;
            Destroy(gameObject);
           
        }
        if (col.gameObject.CompareTag("Player") && gameObject.tag == ("Boar"))
        {
            SoundManager.instance.PlayOneShot(BoarDeath);
            GameObject newFood = (GameObject)Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            newFood.GetComponent<FoodScript>().boarFood = true;
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("Player") && gameObject.tag == ("Bull"))
        {
            SoundManager.instance.PlayOneShot(BullDeath);
            GameObject newFood = (GameObject)Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            newFood.GetComponent<FoodScript>().bullFood = true;
            Destroy(gameObject);

        }

        if(col.gameObject.CompareTag("Bullet"))
        {
            SoundManager.instance.PlayOneShot(Bullet);
            Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            Destroy(gameObject);
            Destroy(col.gameObject);

        }


    }

}
