using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_final : MonoBehaviour
{
	public GameObject Player;
	public GameObject TimelineManager;
	//private Animator animator;
	//public Sprite New_Sprite;


	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Player.GetComponent<Animator>().Play("idle");
			//Player.GetComponent<SpriteRenderer>().sprite = New_Sprite;
			TimelineManager.SetActive(true);
			Player.GetComponent<Player>().enabled = false;
		}
	}
}