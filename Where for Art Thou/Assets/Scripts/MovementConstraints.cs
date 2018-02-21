using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementConstraints : MonoBehaviour
{
    public float baseSpeed;
    public float currSpeed;
    public float changeSpeed;

 
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.right * currSpeed * Time.deltaTime);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -6.26f, -5.26f), transform.position.y);
	}

    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            currSpeed -= baseSpeed * changeSpeed;

        if (Input.GetKeyUp(KeyCode.LeftArrow))
            currSpeed = baseSpeed;

        if (Input.GetKeyDown(KeyCode.RightArrow))
            currSpeed += baseSpeed * changeSpeed;

        if (Input.GetKeyUp(KeyCode.RightArrow))
            currSpeed = baseSpeed;

    }

}
