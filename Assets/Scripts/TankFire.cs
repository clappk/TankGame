using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class TankFire : NetworkBehaviour {
	public float power = 10000f;
	public GameObject shellPrefab;
	public Transform gunBarrel;
	// Use this for initialization
	void Reset () {
		gunBarrel = transform.FindChild ("GunBarrel");
	}
	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer) {
			return;
		}
		if (Input.GetMouseButtonDown (0)) {
			CmdSpawnShell ();
		}
	}
	[Command]
	void CmdSpawnShell()
	{
		GameObject instance = Instantiate (shellPrefab, gunBarrel.position, gunBarrel.rotation)as GameObject;
		instance.GetComponent<Rigidbody> ().AddForce (gunBarrel.forward * power);
		NetworkServer.Spawn (instance);
	}
}
