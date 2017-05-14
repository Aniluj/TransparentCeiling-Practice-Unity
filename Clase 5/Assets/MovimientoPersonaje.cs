using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour {

	public int velocidadMovimiento;
	public int velocidadRotacion;

	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * Time.deltaTime * velocidadMovimiento);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (-Vector3.up * Time.deltaTime * velocidadRotacion);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up * Time.deltaTime * velocidadRotacion);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (-Vector3.forward * Time.deltaTime * velocidadMovimiento);
		}
	}
}
