using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Wifi_live : MonoBehaviour
{
	private int count = 0;
	public GameObject promp;
	public GameObject Player;
	private float distance;
	public float interDist = 6f;
	public KeyCode myKey = KeyCode.X;
	private Animator anim;
	public GameObject Battery;


	void Update()
	{
		distance = Vector3.Distance(Player.GetComponent<Transform>().position, transform.position);
		if (distance < interDist)
		{
			if (count == 0)
			{
				Battery.GetComponent<Animator>().enabled = true;
			}
			count = 1;
			if (Input.GetKeyDown(myKey))
			{
				Battery.GetComponent<Animator>().enabled = true;

			}
		}
	}
}
