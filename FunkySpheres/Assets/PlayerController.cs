using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

	private float moveSpeed = 5;
	private Vector3 moveDirection;
	private float distToGround = 1;
	private float jumpSpeed = 500; 
	private float rigid;
	private Rigidbody rb;
	private float wait = 2;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	public bool IsGrounded()
	{
		return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
	}

	void Update() {
		moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized;
	}

	void FixedUpdate() {
		//GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime);
		rb.MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDirection) * moveSpeed * Time.deltaTime);
		if (Input.GetKeyDown(KeyCode.Space) && IsGrounded ()) 
		{
			StopCoroutine("jump");	//interupt if jumping already
			StartCoroutine("jump");
		} 
	}
	IEnumerator jump(){
		GameObject planet = GameObject.FindWithTag("planet");
		planet.GetComponent<FauxGravityAttractor>().gravity = -12f;
		yield return new WaitForSeconds(wait);
		planet.GetComponent<FauxGravityAttractor>().gravity = -12f;
	}
}