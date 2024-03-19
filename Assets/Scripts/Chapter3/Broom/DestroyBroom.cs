using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBroom : MonoBehaviour
{
    bool swing = false;
    public static bool broken = false;
    private float rotY;
    private float rotPy;

    private string myHandL;
    private string myHandR;

    public Transform playerTransform;
    public Transform BroomTransform;

    public static int cutCount=0;

    // Start is called before the first frame update
    void Start()
    {
        rotY = 0;
        rotPy = 0.7f;
        //cutCount = 0;
        SoundEffects.soundplayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        myHandL = LeftGestureDetector.curHand;
        Debug.Log("Movement : " + myHandL);
        myHandR = RightGestureDetector.curHand;
        Debug.Log("Movement : " + myHandR);

        if (Vector3.Distance(playerTransform.position, BroomTransform.position) < 5.0f)
        {
            if ((myHandR == "RCut") && broken == false)
            {
                swing = true;
                cutCount += 2;
            }
            if (swing == true)
            {                
                if (rotY > 10)
                {
                    rotPy = rotPy * -1;
                }
                rotY = rotY + rotPy;
                transform.localRotation = Quaternion.Euler(90 - rotY, 90, -90);

                if (!SoundEffects.soundplayed)
                {
                    SoundEffects.soundplayed = true;
                    SoundEffects.whatSound = 307;
                }

                //SoundEffects.whatSound = 307;

                if (rotY <= 0)
                {
                    swing = false;
                    SoundEffects.whatSound = 0;
                    rotY = 0;
                    rotPy = rotPy * -1;
                }
            }
        }
    }
}
