using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {

		// mueve el avion hacia el frente
		this.transform.Translate(0.0f,0.0f, 155.0f * Time.deltaTime);

	}
	void OnCollisionEnter(Collision collision){

		if (collision.collider.gameObject.tag == "MarsAlien") {
			GameObject explosion = GameObject.Instantiate (Resources.Load ("Prefab/MarsExplosion") as GameObject);
			explosion.transform.position = collision.collider.gameObject.transform.position;

			//Cuando el misil colisiona con la plataforma la elimina
			Destroy (collision.collider.gameObject);
			Destroy (this.gameObject);
		}
		if (collision.collider.gameObject.tag == "JupiterAlien") {
			GameObject explosion = GameObject.Instantiate (Resources.Load ("Prefab/JupiterExplosion") as GameObject);
			explosion.transform.position = collision.collider.gameObject.transform.position;
			//Cuando el misil colisiona con la plataforma la elimina
			Destroy (collision.collider.gameObject);
			Destroy (this.gameObject);
		}
	}
}