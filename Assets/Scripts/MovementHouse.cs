using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHouse : MonoBehaviour
{
 private string myHandL;
    private string myHandR;
    private string previousGesture;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        previousGesture = "None";
    }

    // Update is called once per frame
    void Update()
    {
        myHandL = LeftGestureDetector.curHand;
        Debug.Log("Movement : " + myHandL);
        myHandR = RightGestureDetector.curHand;
        Debug.Log("Movement : " + myHandR);

        if (!myHandL.Equals(previousGesture))
        {
            //previousGesture = myHand;
            if ((myHandL == "LGoahead"))
            {
                speed = 0.5f;
                if((myHandR == "RGoahead")){
                    speed = 1.5f;
                }
                Vector3 pos = transform.position;
                Vector3 movement = new Vector3(speed, 0, 0);
                transform.Translate(movement/70);
            }
            else if (myHandL == "LRock")
            {
                Vector3 pos = transform.position;
                Vector3 movement = new Vector3(-speed, 0, 0);
                transform.Translate(movement/70);
            }
            else
            {
                Vector3 movement = new Vector3(0, 0, 0);
                transform.Translate(movement);
            }
        }
    }
}
