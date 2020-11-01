﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	public float rotateSpeed = 2;
	void Update()
	{
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * rotateSpeed);
	}
}
