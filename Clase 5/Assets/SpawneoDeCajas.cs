using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneoDeCajas : MonoBehaviour {

	float timer = 0.0f;

	public GameObject[] cajas;

	public Transform posicionDeSpawneo;

	void Update () {

		timer += Time.deltaTime;

		if (timer > 2.0f) {
			int i = Random.Range (0, cajas.Length);
			Instantiate (cajas [i], new Vector3(posicionDeSpawneo.position.x + Random.Range(-13f,13f), posicionDeSpawneo.position.y, posicionDeSpawneo.position.z + Random.Range(-13f,13f)), posicionDeSpawneo.rotation);
			timer = 0.0f;
			}
	}
}
