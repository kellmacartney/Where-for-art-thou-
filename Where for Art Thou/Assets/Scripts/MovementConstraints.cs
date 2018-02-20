using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementConstraints : MonoBehaviour
{
    public float buggySpeed;
    public Vector2 xCon;
    public Vector2 yCon;
    Vector2 wantPos;

	
	// Update is called once per frame
	void Update ()
    {
        wantPos += new Vector2(Input.GetAxis("Horizontal") * buggySpeed * Time.deltaTime, Input.GetAxis("Vertical") * buggySpeed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(wantPos.x, xCon.x, xCon.y), Mathf.Clamp(wantPos.y, yCon.x, yCon.y), transform.position.z);
	}
}
