using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class Bullet : NetworkBehaviour {
	public float age = 0.0f;
	public float shellLifetime = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	[ServerCallback]
	void Update () {
		age += Time.deltaTime;
		if (age > shellLifetime) {
			NetworkServer.Destroy (gameObject);
		}
	}
}
