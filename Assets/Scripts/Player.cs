using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    float speedWalk = 5f;
    float x = 0;
    

    void Start () {
		
	}
	
	void Update () {
	    if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(x += speedWalk * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(x -= speedWalk * Time.deltaTime, 0, 0);
        }
    }
}
