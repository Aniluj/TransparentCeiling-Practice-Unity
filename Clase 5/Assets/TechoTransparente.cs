using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TechoTransparente : MonoBehaviour {

	public MeshRenderer techo;

	public Transform camara;

	private float alpha = 0.1f;


	void Start () 
	{
		
	}

	void Update ()
	{

		RaycastHit hitHaciaArriba;

		Debug.DrawLine (transform.position, camara.position, Color.green);

		if (Physics.Linecast (transform.position, camara.position, out hitHaciaArriba))
		{
				
			if (hitHaciaArriba.transform.tag == "Transparencia" && techo.material.color.a > 0.4f) 
			{
				techo.material.color = new Color (techo.material.color.r, techo.material.color.g, techo.material.color.b, techo.material.color.a - alpha);
			}
		}
		else if (techo.material.color.a < 1f)
		{
			techo.material.color = new Color (techo.material.color.r, techo.material.color.g, techo.material.color.b, techo.material.color.a + alpha);
		}
	  } 
	}