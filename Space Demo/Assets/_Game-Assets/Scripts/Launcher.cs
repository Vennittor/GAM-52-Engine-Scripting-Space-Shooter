using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Launcher
{
	[SerializeField]
	private GameObject shot;
	[SerializeField]
	private Transform firePoint;

	public void  Fire()
	{
		GameObject.Instantiate (shot, firePoint.position, firePoint.rotation);
	}
}

