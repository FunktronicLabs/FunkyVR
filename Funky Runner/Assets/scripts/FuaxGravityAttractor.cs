using UnityEngine;
using System.Collections;

public class fauxgravityattractor : MonoBehaviour {

	public fauxgravityattractor attractor;


	// Use this for initialization
	void Start () {
		rigidbody.constraints = Rigidbody.c
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		attractor.Attract(myTransform);
	}
}
