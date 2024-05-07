using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever_platf_3 : MonoBehaviour
{
	public GameObject Player;
	public GameObject platf;
	public GameObject lever;
	private float distance;
	public float interDist = 2f;
	public KeyCode myKey = KeyCode.X;
	private Animator anim;
	private Animator anim1;

	void Update()
    {
		distance = Vector3.Distance(Player.GetComponent<Transform>().position, transform.position);
		if (distance < interDist)
		{
			if (Input.GetKeyDown(myKey))
			{
				anim1 = lever.GetComponent<Animator>();
				anim1.enabled = true;
				anim =platf.GetComponent<Animator>();
				anim.enabled = true;
				platf.GetComponent<BoxCollider2D>().isTrigger = false;
			}
		}
	}
}
