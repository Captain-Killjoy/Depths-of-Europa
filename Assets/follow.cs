using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	public Transform followTarget;
	public Vector3 distance = new Vector3 (0f,0f,0f);

	public float positionDamping = 0.0f;
	public float rotationDamping   = 0.0f;

	private Transform selfTransform;  



	// Use this for initialization
	void Start () 
	{
		selfTransform = transform; //cached self tranform
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		if (!followTarget) 
		{
			return;
		}

		//position
		//Vector3 wanted_position = followTarget.position;
		//Vector3 current_position = Vector3.Lerp (selfTransform.position, wanted_position, positionDamping * Time.deltaTime);
		//selfTransform.position = current_position;

        transform.position = followTarget.position;

		//rotation


		//Quaternion current_rotation = Quaternion.Lerp (selfTransform.rotation, cameraTarget.rotation, rotationDamping * Time.deltaTime);
		//selfTransform.rotation = current_rotation;


	}


}
