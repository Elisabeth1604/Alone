using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class down_box : MonoBehaviour
{
    public GameObject player;
	public GameObject box;
	public GameObject fade;
	public string sortingLayerName = "Foreground";

	void F()
    {
		player.GetComponent<Animator>().enabled = true;
		box.GetComponent<Animator>().enabled = false;
		player.GetComponent<Renderer>().sortingLayerName = sortingLayerName;
		fade.GetComponent<Animator>().enabled = true;
		fade.GetComponent<Animator>().Play("Fade_opening");
	}
}
