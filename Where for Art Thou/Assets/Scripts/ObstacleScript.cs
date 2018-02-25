using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public AudioClip rockImpact;
    public AudioClip fenceImpact;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D imp)
    {
        if(imp.gameObject.CompareTag ("Player") && gameObject.tag == ("Rock"))
        {
            GameManager.instance.sfxSource.PlayOneShot(rockImpact);
            GameManager.instance.health += 3;
            Destroy(gameObject);
        }

        if (imp.gameObject.CompareTag("Player") && gameObject.tag == ("Fence"))
        {
            GameManager.instance.sfxSource.PlayOneShot(fenceImpact);
            GameManager.instance.health++;
            gameObject.SetActive(false);
        }
    }
}
