using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
	private Camera mainCam;

	public float speed;

	public float bounceBack;
	// Use this for initialization
	void Start () {
	mainCam = Camera.main;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
		
		float horizontalForce = Input.GetAxis("Horizontal")*speed;
		float verticalForce = Input.GetAxis("Vertical")*speed;
		
		
		gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontalForce,verticalForce));
	

		
	










		if (Mathf.Abs(gameObject.transform.position.x) > mainCam.orthographicSize+1)
		{
			gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-gameObject.GetComponent<Rigidbody2D>().velocity.x*bounceBack-gameObject.GetComponent<Rigidbody2D>().velocity.normalized.x,gameObject.GetComponent<Rigidbody2D>().velocity.y);
		}
		if (Mathf.Abs(gameObject.transform.position.y) > mainCam.orthographicSize)
		{
			gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x,-gameObject.GetComponent<Rigidbody2D>().velocity.y*bounceBack-gameObject.GetComponent<Rigidbody2D>().velocity.normalized.y);

		}
	}
}
