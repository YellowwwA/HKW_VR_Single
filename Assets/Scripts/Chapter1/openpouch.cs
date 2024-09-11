using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openpouch : MonoBehaviour
{
    private string myHandL;
    private string myHandR;
    private string previousGesture;

    public Transform pouchTransform;
    public Transform openpouchTransform;
    public Transform cameraTransform;

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
            if ((myHandR == "RCut"))
            {
                if (Vector3.Distance(cameraTransform.position, pouchTransform.position) < 2.0f)
                {
                    pouchTransform.position = new Vector3(145.83f, -0.906f, 52.952f);
                    openpouchTransform.position = new Vector3(145.83f, 0.03147716f, 52.952f);
                    SoundEffects.whatSound = 103;
                }
            }
        }

    }
}
