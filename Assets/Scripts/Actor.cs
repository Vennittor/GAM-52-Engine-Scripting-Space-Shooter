using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour {

	[SerializeField] private float hitPoints = 1.0f;
	[SerializeField] private float damage = 1.0f;
	[SerializeField] private GameObject deathPrefab;

	[SerializeField] private bool usePhysics = false;
	[SerializeField] private Vector3 movementDirection;
	private Rigidbody rigidbody = null;

	public float Speed
	{
		get { return rigidbody.velocity.magnitude; }
		set 
		{
			Vector3 newVelocity = rigidbody.velocity.normalized;
			newVelocity *= value;
			rigidbody.velocity = newVelocity;
		}
	
	}

		
	private void Start()
	{
		rigidbody = GetComponent<Rigidbody> ();
	}

	private void FixedUpdate()
	{
		Move (movementDirection);
	}

	//Movement
	private void Move(Vector3 movement)
	{
		if (!usePhysics) 
		{
			transform.position += movement * Time.fixedDeltaTime;
		}
	}

	//Damage Communication
	private void OnCollisionEnter(Collision collision)
	{
		Actor otherActor = collision.transform.gameObject.GetComponent<Actor>();
		if (otherActor != null)
		{
			otherActor.TakeDamage (damage);
		}
	}

	public void TakeDamage(float damage)
	{
		hitPoints -= damage;
		if (hitPoints <= 0)
		{
			Instantiate (deathPrefab, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}

	//Lifetime

}
