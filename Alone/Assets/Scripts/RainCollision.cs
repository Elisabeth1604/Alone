using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
	
	private void OnParticleCollision(GameObject other)
	{
		if (other.gameObject.tag=="Player")
		{
			
			PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
			if(playerHealth != null )
				playerHealth.Die();
			
		}
	}
}
