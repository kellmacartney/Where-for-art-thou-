using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    public bool boarFood;
    public bool bullFood;
    public bool kangFood;
    //ScoreScript points; 

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == ("Buggy"))
        {
            Destroy(gameObject);
        }
       
       //if(col.gameObject.name == ("Buggy")) //|| bullFood == (true))
      //  {
          //  points.ScoreValue += 15;
          //  Destroy(gameObject);
      //  }

      // if(col.gameObject.name == ("Buggy"))  //|| kangFood == (true))
       // {
         //   points.ScoreValue += 20;
         //   Destroy(gameObject);
       // }

    }


}
