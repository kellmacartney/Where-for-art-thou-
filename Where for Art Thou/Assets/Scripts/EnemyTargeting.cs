using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTargeting : MonoBehaviour
{
    public Transform target;
    public float attackRange;
    public float enemySpeed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector3.Distance(transform.position, target.position) < attackRange)
            transform.position = Vector3.MoveTowards(transform.position, target.position, ( enemySpeed * Time.deltaTime));


    }
}





