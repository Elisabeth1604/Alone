using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform2 : MonoBehaviour
{
	public GameObject platf;
	private Animator anim;

	public Transform pos1, pos2;
	public float speed = 1f;
	public Transform startPos;

	Vector3 nextPos;

	void Start()
	{
		nextPos = startPos.position;
	}
	void Update()
	{
		anim = platf.GetComponent<Animator>();
		if (anim.enabled == true)
		{
			Movement();
		}
	}
	void Movement()
	{
		transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
		if (transform.position == pos1.position)
		{
			nextPos = pos2.position;
		}
		if (transform.position == pos2.position)
		{
			nextPos = pos1.position;
		}
	}
	private void OnDrawGizmos()
	{
		Gizmos.DrawLine(pos1.position, pos2.position);
	}
}
