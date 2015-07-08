using UnityEngine;
using System.Collections;

public class findCenter : MonoBehaviour {

	public Transform target;
	public float smoothTime = 0.3F;
	private Vector3 currentVelocity = Vector3.zero;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPosition = target.position;
		transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime);
	}
}