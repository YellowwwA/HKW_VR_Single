using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock3 : MonoBehaviour
{

    public GameObject unlockPrefab;
    //private Vector3 Pos;
    private float time = 0.1f;

    private string myHandL;
    private string myHandR;
    private string previousGesture;

    public Transform lockTransform;
    //public Transform openpouchTransform;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        previousGesture = "None";
    }

    // Update is called once per frame
    void Update()
    {
        myHandL = LeftGestureDetector.curHand;
        myHandR = RightGestureDetector.curHand;

        if (!myHandR.Equals(previousGesture))
        {
            //previousGesture = myHand;
            if ((myHandR == "RCut")) //오른손 동작이 cut일 때
            {
                if (Vector3.Distance(playerTransform.position, lockTransform.position) < 6.0f) //ovrplayercontroller(나)와 보따리 거리가 2.0미만일때
                {
                    if (GetKey.haveKey == 1)
                    {
                        Vector3 pos = gameObject.transform.position;
                        Destroy(gameObject, time);
                        Instantiate(unlockPrefab, new Vector3(pos.x, pos.y, pos.z), Quaternion.Euler(0, 168, 0));
                        GetKey.haveKey = 0;
                    }

                    //else { Debug.Log("No Key"); }
                }
            }
        }
    }
}
