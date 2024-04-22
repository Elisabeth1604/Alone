using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLever : MonoBehaviour
{
	public GameObject Player;
	private float distance;
	public float interDist = 2f;
	public KeyCode myKey = KeyCode.X;
	private Animation lever;
	void OnMouseOver()
	{
		distance = Vector3.Distance(Player.GetComponent<Transform>().position, transform.position);
		if (distance < interDist)
		{
			if (Input.GetKeyDown(myKey))
			{
				lever = GetComponent<Animation>();
				lever.enabled = true;
			}
		}
	}
}
