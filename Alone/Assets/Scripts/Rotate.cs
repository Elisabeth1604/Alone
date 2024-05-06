using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	public float rotateSpeed = -50f; 
	void Update()
	{
		transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
	}
}
