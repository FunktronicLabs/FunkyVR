using UnityEngine;
using System.Collections;

public class FauxGravityBody : MonoBehaviour {

	public FauxGravityAttractor attractor;
	private Transform myTransform;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().constraints = Rigidbody.FreezeRotation;
		GetComponent<Rigidbody>().useGravity = false;
		myTransform = transform;
	}

	void Update () {
		attractor.Attract(myTransform);
	}
}
