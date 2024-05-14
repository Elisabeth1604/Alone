using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
public class MainMeni : MonoBehaviour
{
    public GameObject TimelineManager;
    public GameObject Start;
    public GameObject Quit;
    public GameObject Enter;
    private bool Timeline_is_active = false;
    public void PlayGame()
    {
		TimelineManager.SetActive(true); //включили анимацию
        Timeline_is_active = true;
	}
    public void QuitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }

	private void Update()
	{
        if (TimelineManager.GetComponent<PlayableDirector>().time >= 9.75f && TimelineManager.GetComponent<PlayableDirector>().time <= 9.76f && Timeline_is_active)
		{

			TimelineManager.GetComponent<PlayableDirector>().Pause();
			Enter.GetComponent<Animator>().enabled = true;
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Enter.SetActive(false);
                TimelineManager.GetComponent<PlayableDirector>().Resume();
            }
		}
        if (TimelineManager.GetComponent<PlayableDirector>().time >= 16f && Timeline_is_active)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
