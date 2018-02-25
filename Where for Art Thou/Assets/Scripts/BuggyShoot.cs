using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuggyShoot : MonoBehaviour
{
    public Animator anim;
    public Animation Shoot;
    public Transform spawnPoint;
    public GameObject BulletPreFab;
    public bool isfiring;
    public float fireRate;
    public AudioClip fire; 

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(BulletCooldown());
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isfiring = true;
        }
        else
        {
            isfiring = false;
        }
    }
    IEnumerator BulletCooldown()
    {
        if (isfiring)
        {
            ShootBullet();

        }

        yield return new WaitForSeconds(fireRate);
        StartCoroutine(BulletCooldown());

    }

    public void ShootBullet()
    {//generates bullet
        anim.Play("Shoot");
        GameManager.instance.sfxSource.PlayOneShot(fire);
        GameObject newBullet = (GameObject)Instantiate(BulletPreFab, spawnPoint.position, Quaternion.identity);
        Destroy(newBullet, newBullet.GetComponent<BulletScript>().LifeTime);
    }
}
