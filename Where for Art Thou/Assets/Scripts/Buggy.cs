using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buggy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnEnable()
    {
        GameManager.instance.InitLevel();
    }

}
