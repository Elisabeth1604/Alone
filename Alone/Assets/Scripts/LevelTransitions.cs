using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransitions : MonoBehaviour
{

   public void ChangeScene(int scene)
	{
		if(SceneManager.GetActiveScene().buildIndex==5)
			SceneManager.LoadScene(0);
		else
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
