using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class FauxGravityBody : MonoBehaviour {

	public FauxGravityAttractor attractor;
	private Transform myTransform;

	void Start () {
		GetComponent<Rigidbody>().useGravity = false;
		Debug.Log ("Player doesn't use gravity");
		GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
		Debug.Log ("Player's rotate is locked");

		myTransform = transform;
	}

	void FixedUpdate () {
		if (attractor){
			attractor.Attract(myTransform);
		}
	}
	
}
