using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
	public GameObject Player;
	public GameObject ladder;
	private float distance;
	public float interDist = 2f;
	public KeyCode myKey;
	public Transform pos1, pos2;
	public float speed = 1f;
	public Transform startPos;
	Vector3 nextPos;
	public Sprite newSprite;
	void Start()
	{
		nextPos = startPos.position;
	}
	void Update()
    {
		distance = Vector3.Distance(Player.GetComponent<Transform>().position, ladder.GetComponent<Transform>().position);
		if (distance < interDist)
		{
			if (Input.GetKeyDown(myKey))
			{
				
				Movement();
				//ladder.GetComponent<BoxCollider2D>().enabled = false;
			}
		}
	}
	void Movement()
	{
		//pos1.position = Player.GetComponent<Transform>().position;
		transform.position = Vector3.MoveTowards(Player.transform.position, nextPos, speed * Time.deltaTime);
		if (Player.transform.position == pos1.position)
		{
			nextPos = pos2.position;
		}
		if (Player.transform.position == pos2.position)
		{
			nextPos = pos1.position;
		}
	}
	private void OnDrawGizmos()
	{
		Gizmos.DrawLine(pos1.position, pos2.position);
	}
}
