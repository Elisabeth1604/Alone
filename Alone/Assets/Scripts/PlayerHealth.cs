using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
	public int maxHealth = 10;
	public int currentHealth;
	void Start()
	{
		currentHealth = maxHealth;
	}

	public void TakeDamage(int damageAmount)
	{
		currentHealth -= damageAmount;
		if (currentHealth <= 0)
		{
			Die();
		}
	}

	public void Heal(int healAmount)
	{
		currentHealth = Mathf.Min(currentHealth + healAmount, maxHealth);
		Debug.Log("-1");
	}

	public void Die()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		// Ћогика обработки смерти персонажа
		//Debug.Log("»грок умер!");
		currentHealth = maxHealth;

		// ƒополнительные действи€ при смерти, например, загрузка меню или респаун
	}
}
