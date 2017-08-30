using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon 
{
	[SerializeField]
	private string name;
	[SerializeField]
	private Launcher[] projectileLauncher;

	public void  Fire()
	{
		foreach (Launcher l in projectileLauncher) 
		{
			l.Fire();
		}
	}
}
