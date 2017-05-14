using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {

	void Start ()
	{
		
	}

	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			RaycastHit informacionDelHit;

			if(Physics.Raycast (transform.position, transform.up, out informacionDelHit))
			{
				informacionDelHit.rigidbody.AddForceAtPosition (transform.up * 10f, informacionDelHit.point, ForceMode.Impulse);
			}

		}
	}
}
