using UnityEngine;
using System.Collections;

public class MissileBolt : MonoBehaviour
{
	[SerializeField]
	private float speed;
	private GameObject target;
	private Vector3 direction;

	void Start()
	{
		direction = transform.forward;
		FindBestTarget();
	}

	void Update()
	{
		if (target == null) 
		{
			FindBestTarget();
		}
	}

	void FixedUpdate ()
	{
		if (target != null) 
		{
			direction = (target.transform.position - transform.position).normalized;
			transform.LookAt (target.transform.position);
		} 

	 	Vector3 velocity = direction * speed * Time.fixedDeltaTime ;
		transform.position += velocity;

	}

	private void FindBestTarget()
	{
		GameObject [] targets = GameObject.FindGameObjectsWithTag("Enemy");

		float minmum = Mathf.Infinity;
		foreach (GameObject g in targets) 
		{
			float distance = Vector3.Distance (g.transform.position, transform.position);
			if (distance < minmum) 
			{
				target = g;
				minmum = distance;
			}
		}
	}

}
