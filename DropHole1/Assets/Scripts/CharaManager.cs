using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaManager : MonoBehaviour {


    public float speed = 10;

	
	// Update is called once per frame
	void Update () {


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rig = GetComponent<Rigidbody>();

        rig.AddForce(x * speed , 0, z * speed);

		
	}
}
