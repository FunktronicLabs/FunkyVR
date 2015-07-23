using UnityEngine;
using System.Collections;

public class FauxGravityAttractor : MonoBehaviour {

	public float gravity = -12;
	public float truegrav;
	public float distance;
	public GameObject object1;
	public GameObject object2;
	public float m1;
	public float m2;


	void Start(){
		object1 = GameObject.FindGameObjectWithTag("planet");
		object2 = GameObject.FindGameObjectWithTag("Player");
		m1 = object1.GetComponent<Rigidbody>().mass;
		m2 = object2.GetComponent<Rigidbody>().mass;
		distance = Vector3.Distance(object1.transform.position, object2.transform.position);
		truegrav = gravity * m1 * m2 / (distance * distance);

	}

	public void Attract(Transform body) {
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 localUp = body.up;

		body.GetComponent<Rigidbody>().AddForce(gravityUp * truegrav);

		Quaternion targetRotation = Quaternion.FromToRotation(localUp,gravityUp) * body.rotation;
		body.rotation = Quaternion.Slerp(body.rotation,targetRotation,50f * Time.deltaTime );
	}

}