using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
	public Sprite New_Sprite;
	public GameObject Player;
	public GameObject ladder;
	public GameObject platf;
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
				other.GetComponent<Rigidbody2D>().velocity = new Vector2(other.GetComponent<Rigidbody2D>().velocity.x, verticalInput * climbSpeed);
				other.GetComponent<Rigidbody2D>().gravityScale = 0;
				isClimbing = true;
				Player.GetComponent<Animator>().enabled = false;
				Player.GetComponent<SpriteRenderer>().sprite = New_Sprite;
				platf.GetComponent<BoxCollider2D>().enabled = false;
			}
			else
			{
				other.GetComponent<Rigidbody2D>().velocity = new Vector2(other.GetComponent<Rigidbody2D>().velocity.x, 0);
				other.GetComponent<Rigidbody2D>().gravityScale = 2;
				isClimbing = false;
				platf.GetComponent<BoxCollider2D>().enabled = true;
				Player.GetComponent<Animator>().enabled = true;
			}
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			other.GetComponent<Rigidbody2D>().gravityScale = 2;
			isClimbing = false;
			Player.GetComponent<Animator>().enabled = true;
			platf.GetComponent<BoxCollider2D>().enabled = true;
		}
	}
	
}
