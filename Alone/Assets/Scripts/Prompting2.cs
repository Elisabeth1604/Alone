using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prompting2 : MonoBehaviour
{
	public GameObject battery1;
	public GameObject X;
	void F()
	{
		Battery battery = battery1.GetComponent<Battery>();
		bool flag1 = battery.flag;
		if (flag1 == true)
		{
			X.GetComponent<Animator>().enabled = false;
		}
	}
}
