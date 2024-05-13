using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class down_box : MonoBehaviour
{
    public GameObject player;
    void F()
    {
       player.GetComponent<Animator>().enabled = true;
	}
}
