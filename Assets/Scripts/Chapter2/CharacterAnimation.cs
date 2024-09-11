using UnityEngine;
using System.Collections;

public class CharacterAnimation : MonoBehaviour {

	public float walkSpeed = 3.0f;
	private Vector3 prevPos;

	// Use this for initialization
	void Start ()
	{
		GetComponent<Animation>()["Walk"].speed = walkSpeed;
		prevPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		prevPos = transform.position;
	}
}
