using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int bulletSpeed;
    public int Dmg;
    public float LifeTime;
    

   

    // Use this for initialization
    void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
    }
}
