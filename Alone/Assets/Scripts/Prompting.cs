using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prompting : MonoBehaviour
{
    public GameObject battery1;
	public GameObject X;
    public GameObject lever;
	public GameObject lever1;
	public string lname;

	void F()
    {
		Battery battery = battery1.GetComponent<Battery>();
		bool flag1 = battery.flag;
		if (lname == "3")
		{
			if (lever.GetComponent<Animator>().enabled == true | lever1.GetComponent<Animator>().enabled == true | flag1 == true)
			{
				X.GetComponent<Animator>().enabled = false;
				lever.GetComponent<Animator>().enabled = false;
			}
		}
		if (lname == "1" || lname == "2")
		{
			if (lever.GetComponent<Animator>().enabled == true | flag1 == true)
			{
				X.GetComponent<Animator>().enabled = false;
			}
		}
    }
}
