using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class tankScript : NetworkBehaviour {
    float moveSpeed = 3;
	// Use this for initialization
	void Start () {
		if (!isLocalPlayer) {
			Destroy (this);
			return;
		}
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
    }
}
