using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
	public GameObject Player;

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("TV"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}