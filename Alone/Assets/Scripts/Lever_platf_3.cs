using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever_platf_3 : MonoBehaviour
{
	private int count = 0;
	private int count1 = 0;
	public GameObject promp;
	public GameObject Player;
	public GameObject platf;
	public GameObject lever;
	private float distance;
	public float interDist = 2f;
	public KeyCode myKey = KeyCode.X;
	private Animator anim;
	private Animator anim1;
	private AudioSource leverAudio;
	private bool soundPlayed = false;

	void Start()
	{
		leverAudio = GetComponent<AudioSource>();
	}
	void Update()
    {
		distance = Vector3.Distance(Player.GetComponent<Transform>().position, transform.position);
		if (distance < interDist)
		{
			if (count == 0 || count==2)
			{
				promp.GetComponent<Animator>().enabled = true;
			}
			count = 1;
			if (Input.GetKeyDown(myKey))
			{
				anim1 = lever.GetComponent<Animator>();
				anim1.enabled = true;
				anim = platf.GetComponent<Animator>();
				anim.enabled = true;
				platf.GetComponent<BoxCollider2D>().isTrigger = false;
				count = 2;
				if (leverAudio != null && !leverAudio.isPlaying && !soundPlayed)
				{
					leverAudio.Play();
					soundPlayed = true;
				}
			}
		}
	}
}
