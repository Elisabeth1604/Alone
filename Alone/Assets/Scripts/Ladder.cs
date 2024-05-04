using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
	public GameObject Player;
	public GameObject ladder;
	public KeyCode myKey;
	private bool isMoving = false;
	private float targetY;
	private Rigidbody2D rb;
	//public Sprite newSprite;
	public float climbSpeed = 5f;

	private bool isClimbing = false;

	void OnTriggerStay2D(Collider2D other)
	{
		Player.GetComponent<Rigidbody2D>().WakeUp();
		if (other.gameObject.CompareTag("Player"))
		{
			float verticalInput = Input.GetAxis("Vertical");

			if (verticalInput != 0)
			{
				Player.GetComponent<Rigidbody2D>().WakeUp();
				other.GetComponent<Rigidbody2D>().velocity = new Vector2(other.GetComponent<Rigidbody2D>().velocity.x, verticalInput * climbSpeed);
				other.GetComponent<Rigidbody2D>().gravityScale = 0;
				isClimbing = true;
			}
			else
			{
				other.GetComponent<Rigidbody2D>().velocity = new Vector2(other.GetComponent<Rigidbody2D>().velocity.x, 0);
				other.GetComponent<Rigidbody2D>().gravityScale = 1;
				isClimbing = false;
			}
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			other.GetComponent<Rigidbody2D>().gravityScale = 1;
			isClimbing = false;
		}
	}
	
}
