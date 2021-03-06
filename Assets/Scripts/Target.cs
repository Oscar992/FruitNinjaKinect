﻿using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().angularVelocity = new Vector3(Random.Range(-6f,6f),Random.Range(-6f,6f),Random.Range(-6f,6f));

		if (gameObject.tag == "Bomb") 
			GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-0.5f,0.5f)* 1.4f,Random.Range(1f,1.5f) *1.4f,0f));
		else
		GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-0.5f,0.5f)*1.1f,Random.Range(1f,1.5f)*1.1f,0f));


		//Destroy the fruit so we dont fill up our memory
		if (name.Contains("Clone")) {
			Destroy (gameObject, 10);
		}
	}
}
