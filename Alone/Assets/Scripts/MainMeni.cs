using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMeni : MonoBehaviour
{
    public GameObject TimelineManager;
    public GameObject Start;
    public GameObject Quit;
    public void PlayGame()
    {
		TimelineManager.SetActive(true); //�������� ��������
        Start.SetActive(false); //��������� ������
		Quit.SetActive(false);
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		//Start.SetActive(true); //������� �������
		//Quit.SetActive(true);
	}
    public void QuitGame()
    {
        Debug.Log("���� ���������");
        Application.Quit();
    }
}
