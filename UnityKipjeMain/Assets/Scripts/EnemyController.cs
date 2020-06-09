using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class EnemyController : MonoBehaviour {


	public float speed;
 	private Transform target;

	void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}

	void Update ()
	{
		// Get the distance to the player
		transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
	}

	// Point towards the player
	void FaceTarget ()
	{
		Vector3 direction = (target.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
		transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
	}


}