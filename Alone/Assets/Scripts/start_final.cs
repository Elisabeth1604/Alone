using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_final : MonoBehaviour
{
	public GameObject Player;
	public GameObject TimelineManager;
	public GameObject MainCamera;
	public GameObject VirtualCamera;
	public GameObject ZoomCamera;



	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Player.GetComponent<Animator>().Play("idle");
			TimelineManager.SetActive(true); //�������� ��������
			Player.GetComponent<Player>().enabled = false; //��������� ������ ������
			VirtualCamera.GetComponent<CinemachineVirtualCamera>().Follow = null;
			//MainCamera.SetActive(false); //��������� ������
			//VirtualCamera.SetActive(false);

			//ZoomCamera.SetActive(true);
		}
	}
}