using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV_down : MonoBehaviour
{
	public GameObject Player;
	private Animator anim;
	private Animator anim_tv;
	
    void Update()
    {
		anim = GetComponent<Animator>();
		anim_tv = GetComponent<Animator>();
		if (anim.enabled ==true)
        {
			anim_tv.enabled = true;

		}
    }
}
