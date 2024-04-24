using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLever : MonoBehaviour
{
	public GameObject TV;
	public GameObject Player;
	private float distance;
	public float interDist = 2f;
	public KeyCode myKey = KeyCode.X;
	private Animator anim;
	void Update()
	{
		distance = Vector3.Distance(Player.GetComponent<Transform>().position, transform.position);
		if (distance < interDist)
		{
			if (Input.GetKeyDown(myKey))
			{
				anim = GetComponent<Animator>();
				anim.enabled = true;
				TV.AddComponent<Rigidbody2D>();
				//TV.GetComponent<Rigidbody2D>().isKinematic = true;
			}
		}
	}
	
}
