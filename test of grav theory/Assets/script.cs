using UnityEngine;
public class script : MonoBehaviour
{ 
	float gravity = -9.8f;
	[SerializeField] GameObject target;
	void Start ()
	{

	}

	void Update () 
	{
		//target.GetComponent<Rigidbody>().velocity += transform.position.normalized * gravity * Time.deltaTime;
		target.GetComponent<Rigidbody>().velocity += transform.position * gravity * Time.deltaTime;
	}
}