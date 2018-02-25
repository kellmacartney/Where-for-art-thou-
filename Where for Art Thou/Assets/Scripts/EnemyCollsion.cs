using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollsion : MonoBehaviour
{
    
    public GameObject FoodPreFab;
    public int Damage = 1;
    
    public AudioClip KangarooDeath;
    public AudioClip BoarDeath;
    public AudioClip BullDeath;
    public AudioClip Bullet;
    public AudioClip foodSpawn; 

    // Use this for initialization
    void Start ()
    {
        
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") && gameObject.tag == ("Kangaroo"))
        {
            GameManager.instance.sfxSource.PlayOneShot(foodSpawn);
            GameManager.instance.AddHP(1);
            GameManager.instance.sfxSource.PlayOneShot(KangarooDeath);
            GameObject newFood = (GameObject)Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            newFood.GetComponent<FoodScript>().kangFood = true;
            Destroy(gameObject);
           
        }
        if (col.gameObject.CompareTag("Player") && gameObject.tag == ("Boar"))
        {
            GameManager.instance.sfxSource.PlayOneShot(foodSpawn);
            GameManager.instance.AddHP(1);
            GameManager.instance.sfxSource.PlayOneShot(BoarDeath);
            GameObject newFood = (GameObject)Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            newFood.GetComponent<FoodScript>().boarFood = true;
            Destroy(gameObject);
        }

        if (col.gameObject.CompareTag("Player") && gameObject.tag == ("Bull"))
        {
            GameManager.instance.sfxSource.PlayOneShot(foodSpawn);
            GameManager.instance.AddHP(1);
            GameManager.instance.sfxSource.PlayOneShot(BullDeath);
            GameObject newFood = (GameObject)Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
            newFood.GetComponent<FoodScript>().bullFood = true;
            Destroy(gameObject);

        }

        

            if (col.gameObject.CompareTag("Bullet") && gameObject.tag == "Kangaroo")

            {
                 GameManager.instance.sfxSource.PlayOneShot(foodSpawn);
                 GameManager.instance.sfxSource.PlayOneShot(KangarooDeath);
                GameManager.instance.sfxSource.PlayOneShot(Bullet);
                Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
                Destroy(gameObject);
                Destroy(col.gameObject);

            }

            if (col.gameObject.CompareTag("Bullet") && gameObject.tag == "Bull")
            {
            GameManager.instance.sfxSource.PlayOneShot(foodSpawn);
            GameManager.instance.sfxSource.PlayOneShot(BullDeath);
                GameManager.instance.sfxSource.PlayOneShot(Bullet);
                Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
                Destroy(gameObject);
                Destroy(col.gameObject);

            }

            if (col.gameObject.CompareTag("Bullet") && gameObject.tag == "Boar")
            {

            GameManager.instance.sfxSource.PlayOneShot(foodSpawn);
            GameManager.instance.sfxSource.PlayOneShot(KangarooDeath);
                GameManager.instance.sfxSource.PlayOneShot(Bullet);
                Instantiate(FoodPreFab, col.transform.position, col.transform.rotation);
                Destroy(gameObject);
                Destroy(col.gameObject);

            }
        }


    

}
