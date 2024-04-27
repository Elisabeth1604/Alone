using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static System.Net.Mime.MediaTypeNames;

public class Battery : MonoBehaviour
{
	public GameObject Player;
	public GameObject battery;
	public GameObject panel;
	private float distance;
	public float interDist = 2f;
	public KeyCode myKey = KeyCode.X;
	private Animator anim;
	public Sprite newSprite;
	void Update()
	{
		distance = Vector3.Distance(Player.GetComponent<Transform>().position, transform.position);
		if (distance < interDist)
		{
			if (Input.GetKeyDown(myKey))
			{
				anim = GetComponent<Animator>();
				anim.PlayInFixedTime("battery_move", 1, 0.0f);
				battery.GetComponent<BoxCollider2D>().enabled = false;
				anim.Play("battery_get");
				panel.GetComponent<SpriteRenderer>().sprite = newSprite;
			}
		}
	}
}
		
