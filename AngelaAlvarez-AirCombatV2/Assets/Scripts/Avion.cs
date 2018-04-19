using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (0, 0, 10f * Time.deltaTime);

	

			if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate (0.0f, 10f * Time.deltaTime, 0.0f);
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (0.0f, -10f * Time.deltaTime, 0.0f);
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (10f * Time.deltaTime, 0.0f, 0.0f);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (-10f * Time.deltaTime, 0.0f, 0.0f);
			}


			if (Input.GetKeyDown (KeyCode.Space)) {	

				GameObject missile = GameObject.Instantiate (
					Resources.Load ("Prefab/Missil")as GameObject);
				missile.transform.SetParent (this.gameObject.transform);
				missile.transform.localPosition = new Vector3 (3.16f, 1.03f, -0.71f);
				missile.transform.SetParent (null);

			GameObject missile2 = GameObject.Instantiate (
				Resources.Load ("Prefab/Missil")as GameObject);
			missile2.transform.SetParent (this.gameObject.transform);
			missile2.transform.localPosition = new Vector3 (-3.16f, 1.03f, -0.71f);
			missile2.transform.SetParent (null);

		}
	}
}
