using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Branch_down : MonoBehaviour
{
	public GameObject Branch;
	public AudioSource branchAudio;

	void Start()
	{
		branchAudio = GetComponent<AudioSource>();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Branch.AddComponent<Rigidbody2D>();
			Branch.GetComponent<Rigidbody2D>().mass = 20;
			Branch.GetComponent<Rigidbody2D>().gravityScale = 2;
			Branch.GetComponent<BoxCollider2D>().isTrigger = false;

			if (branchAudio != null && !branchAudio.isPlaying)
			{
				branchAudio.PlayOneShot(branchAudio.clip);
			}
		}
	}
}