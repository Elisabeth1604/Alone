using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV2_down_platf2 : MonoBehaviour
{
	public GameObject TV;
	private Animator anim;
	private float distance;
	public float interDist = 2f;
	void Update()
	{
		distance = Vector3.Distance(TV.GetComponent<Transform>().position, transform.position);
		if (distance < interDist)
		{
			anim = GetComponent<Animator>();
			anim.enabled = true;
		}
	}
}
