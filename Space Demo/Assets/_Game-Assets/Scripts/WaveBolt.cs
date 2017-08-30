using UnityEngine;
using System.Collections;

public class WaveBolt : MonoBehaviour
{
	[SerializeField]
	private float waveMovement = 0.5f;
	[SerializeField]
	private float speed;
	private Vector3 forwardMovementVector;

	void Start()
	{
		forwardMovementVector = transform.forward * speed;
	}

	void FixedUpdate ()
	{
		float sinZ = Mathf.Sin (transform.position.z);
		float waveSize = sinZ * waveMovement;
		transform.position += (forwardMovementVector + new Vector3(waveSize,0,0)) * Time.fixedDeltaTime ;
	}
}
