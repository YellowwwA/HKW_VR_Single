using UnityEngine;
using System.Collections;
//using UnityEngine.UI;

public class AIMoving : MonoBehaviour {
	UnityEngine.AI.NavMeshAgent agent = null;
	public Transform[] wayPoints = null;
	int wayCount = 0;





	void MoveToNextWayPoint(){
		if(agent.velocity == Vector3.zero)
		{
			int RandomInt = Random.Range(0, wayPoints.Length);
			agent.SetDestination (wayPoints[RandomInt].position);

			//if(wayCount>=wayPoints.Length)
			//	wayCount=0;
		}

	}
	// Use this for initialization
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		InvokeRepeating ("MoveToNextWayPoint", 0f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		//animation.CrossFade ("Walk", 0.1f);
	}

}
