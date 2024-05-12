using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_BG : MonoBehaviour
{
	public string lname;
	public GameObject BGMusic;
	private AudioSource AudioSource;
	public GameObject[] objs11;

	private void Awake()
	{
		objs11 = GameObject.FindGameObjectsWithTag("Sound");
		if (objs11.Length == 0)
		{
			BGMusic = Instantiate(BGMusic);
			BGMusic.name = "BGMusic";
			DontDestroyOnLoad(BGMusic.gameObject);
			
		}
		else
		{
			BGMusic = GameObject.Find("BGMusic");
		}
	}

	private void Start()
	{
		AudioSource = BGMusic.GetComponent<AudioSource>();
		if (lname == "4")
			AudioSource.Stop();
	}
}
