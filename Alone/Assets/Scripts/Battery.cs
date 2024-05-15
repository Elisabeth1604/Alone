using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;

public class Battery : MonoBehaviour
{
	public bool flag = false;
	public GameObject lever;
	public GameObject lever1;
	private int count = 0;
	public GameObject promp;
	public GameObject Player;
	public GameObject battery;
	public GameObject panel;
	public GameObject FideIn;
	private float distance;
	public float interDist = 2f;
	public KeyCode myKey = KeyCode.X;
	private Animator anim;
	private Animator anim1;
	public Sprite newSprite;
	public string lname;
	public AudioSource audioSource; 
	public AudioClip batterySound; 


	private void Start()
	{
		lname = SceneManager.GetActiveScene().name;
		audioSource = GetComponent<AudioSource>();
	}
	void Update()
	{
		distance = Vector3.Distance(Player.GetComponent<Transform>().position, transform.position);
		if (distance < interDist)
		{
			
			if (count == 0)
			{
				promp.GetComponent<Animator>().enabled = true;
			}
			count = 1;
			if (lname == "1")
				lever.GetComponent<Animator>().enabled = false;
			if (lname == "3")
			{
				lever.GetComponent<Animator>().enabled = false;
				lever1.GetComponent<Animator>().enabled = false;
			}
				if (Input.GetKeyDown(myKey))
			{
				anim = GetComponent<Animator>();
				//if(lname=="1")
				//	anim.PlayInFixedTime("battery_move", 1, 0.0f);
    //            else
    //            {
    //                if(lname=="2")
				//		anim.PlayInFixedTime("2battery_move", 1, 0.0f);
				//	else
				//	{
				//		if (lname == "2")
				//			anim.PlayInFixedTime("3battery_move", 1, 0.0f);
				//	}
				//}
				battery.GetComponent<BoxCollider2D>().enabled = false;
				StartCoroutine(waiter());
				
			}
		}
	}
	IEnumerator waiter()
	{
		if (lname == "1")
			anim.Play("battery_get");
		else
		{
			if (lname == "2")
				anim.Play("2battery_get");
			else
			{   if(lname == "3")
					anim.Play("3battery_get");
			}
		}
		flag = true;
		audioSource.PlayOneShot(batterySound);
		yield return new WaitForSeconds((float)1.9);
		panel.GetComponent<SpriteRenderer>().sprite = newSprite;
		anim1 =FideIn.GetComponent<Animator>();
		if (lname == "1")
		{
			anim1.Play("fade_in");
		}
		else
		{
			if (lname == "2")
				anim1.Play("fade_in2");
			if (lname == "3")
			{ 
				anim1.Play("fade_in3");

			}
		}
	}
	
}
		
