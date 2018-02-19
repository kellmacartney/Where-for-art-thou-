using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuggyJump : MonoBehaviour
{
    public  float maxJumpHeight;
    float groundHeight;
    Vector3 groundPos;
    public float jumpSpeed;
    public float fallSpeed;

    public bool inputJump = false;
    public bool grounded = true; 
   

    void Start()
    {
        groundPos = transform.position;
        groundHeight = transform.position.y;
        maxJumpHeight = transform.position.y + maxJumpHeight;
    }



    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if(grounded)
            {
                groundPos = transform.position;
                inputJump = true;
                StartCoroutine("Jump");
            }
        }
        if (transform.position == groundPos)
            grounded = true;
        else
            grounded = false; 
	}

    IEnumerator Jump()
    {
        while(true)
        {
            if (transform.position.y > maxJumpHeight)
                inputJump = false;
            if (inputJump)
                transform.Translate(Vector3.up * jumpSpeed * Time.smoothDeltaTime);

            else if (!inputJump)
            {
                transform.position = Vector3.Lerp(transform.position, groundPos, fallSpeed * Time.smoothDeltaTime);
            }
            if (transform.position == groundPos)
                StopAllCoroutines();

            yield return new WaitForEndOfFrame();
        }
       
    }
   
}
