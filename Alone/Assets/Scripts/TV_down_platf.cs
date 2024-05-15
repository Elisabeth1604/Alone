using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV_down_platf : MonoBehaviour
{
	public GameObject TV;
	private Animator anim;
	private float distance;
	public float interDist = 2f;
	public AudioSource platformAudio;
	private bool hasPlayed = false;
	void Start()
	{
		platformAudio = GetComponent<AudioSource>(); 
	}

	void Update()
	{
		distance = Vector3.Distance(TV.transform.position, transform.position);
		if (distance < interDist && !hasPlayed)
		{
			anim = GetComponent<Animator>();
			anim.enabled = true;

			if (platformAudio != null)
			{
				platformAudio.PlayOneShot(platformAudio.clip);
				hasPlayed = true;
			}
		}
	}
}