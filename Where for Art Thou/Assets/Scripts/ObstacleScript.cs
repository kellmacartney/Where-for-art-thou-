using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public AudioClip rockImpact;
    public AudioClip fenceImpact;
    public AudioClip fenceDeath;
    public AudioClip bulletImpact;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D imp)
    {
        if (imp.gameObject.CompareTag("Player") && gameObject.tag == ("Rock"))
        {
            GameManager.instance.sfxSource.PlayOneShot(rockImpact);
            GameManager.instance.health++ ;
            Destroy(gameObject);
        }

        if (imp.gameObject.CompareTag("Player") && gameObject.tag == ("Fence"))
        {
            GameManager.instance.sfxSource.PlayOneShot(fenceImpact);
            GameManager.instance.health++;
            gameObject.SetActive(false);
        }

        if (imp.gameObject.CompareTag("Bullet") && gameObject.tag == "Fence")

        {
            GameManager.instance.sfxSource.PlayOneShot(fenceDeath);
            GameManager.instance.sfxSource.PlayOneShot(bulletImpact);
            Destroy(gameObject);
            Destroy(imp.gameObject);
        }

       
    }
}
