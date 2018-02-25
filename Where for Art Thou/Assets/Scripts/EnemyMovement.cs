using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float enemySpeed;
    public AudioClip bullWalk;
    public AudioClip boarWalk;
    public AudioClip KangarooWalk; 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate((Vector2.left * enemySpeed ) * Time.deltaTime);

    }


    private void SoundCheck ()
    {
        if (gameObject.tag == "Bull")
        {
            SoundManager.instance.PlayOneShot(bullWalk);
        }

        if (gameObject.tag == "Boar")
        {
            SoundManager.instance.PlayOneShot(boarWalk);
        }

        if (gameObject.tag == "Kangaroo")
        {
            SoundManager.instance.PlayOneShot(KangarooWalk);
        }
    }
}
