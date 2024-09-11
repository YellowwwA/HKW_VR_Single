using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class broommovement : MonoBehaviour
{
    private string myHandL;
    private string myHandR;
    private string previousGesture;

    // Update is called once per frame
    void Update()
    {
        myHandL = LeftGestureDetector.curHand;
        //Debug.Log("Movement : " + myHandL);
        myHandR = RightGestureDetector.curHand;
        //Debug.Log("Movement : " + myHandR);

        Vector3 pos = transform.position;
        Vector3 movement = new Vector3(0, 0, 2.2f);
        transform.Translate(movement/80);
        if(transform.position.z >= 60){
            SceneManager.LoadScene(13);
        }

        if (!myHandL.Equals(previousGesture))
        {
            //previousGesture = myHand;
            if ((myHandL == "LUp"))
            {
                //speed = 1f;
                if(transform.position.y <= 6){
                    pos = transform.position;
                     movement = new Vector3(0, 1, 0);
                    transform.Translate(movement/50);
                }
            }
            else if (myHandR == "RDown")
            {
                if(transform.position.y >=3){
                    pos = transform.position;
                     movement = new Vector3(0, -1, 0);
                    transform.Translate(movement/40);
                }
            }
        }
    }
}
