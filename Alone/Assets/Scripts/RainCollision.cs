using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
	public int count = 0;
	private void OnParticleCollision(GameObject other)
	{
		if (other.gameObject.tag=="Player")
		{
			count++;
			PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
			if (count == 3)
			{ 
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
				count = 0;
			}


		}
	}
}
