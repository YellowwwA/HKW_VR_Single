using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementCandyscene : MonoBehaviour
{   private string myHandL;
    private string myHandR;
    private string previousGesture;
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
                Vector3 pos = transform.position;
                Vector3 movement = new Vector3(0, 0, 1);
                transform.Translate(movement/70);
            }
            else if (myHandL == "LRock")
            {
                Vector3 pos = transform.position;
                Vector3 movement = new Vector3(0, 0, -1);
                transform.Translate(movement/70);
            }
            else
            {
                Vector3 movement = new Vector3(0, 0, 0);
                transform.Translate(movement);
            }
        }
        else
        {
            Vector3 movement = new Vector3(0, 0, 0);
            transform.Translate(movement);
        }
    }
}
