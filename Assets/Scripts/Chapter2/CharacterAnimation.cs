using UnityEngine;
using System.Collections;

public class CharacterAnimation : MonoBehaviour {

	public float walkSpeed = 3.0f;
	private Vector3 prevPos;
	//private float tolerable = 2.0f;

	//bool IsItWithinRange(Vector3 v1, Vector3 v2)
	//{
	//	if ((v1 - v2).sqrMagnitude < tolerable)
	//		return true;
	//	else
	//		return false;
	//}

	// Use this for initialization
	void Start () {
		GetComponent<Animation>()["Walk"].speed = walkSpeed;
		prevPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	//	if (!IsItWithinRange (prevPos, transform.position))
	//			GetComponent<Animation>().CrossFade ("Idle", 0.1f);
	//	else
	//			GetComponent<Animation>().CrossFade ("Walk", 0.5f);

		prevPos = transform.position;
	}
}
