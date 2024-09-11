using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cageopen : MonoBehaviour
{
    GameObject CageDoor;
    private float rot=180;
    public Transform playerTransform;
    public Transform CageDoortransform;
    private string myHandL;
    private string myHandR;

    // Start is called before the first frame update
    void Start()
    {   
        CageDoor = GameObject.FindGameObjectWithTag("CageDoor");
        //rot = 180;
        SoundEffects.soundplayed = false;

    }

    // Update is called once per frame
    void Update()
    {
        myHandL = LeftGestureDetector.curHand;
        //Debug.Log("Movement : " + myHandL);
        myHandR = RightGestureDetector.curHand;
        //Debug.Log("Movement : " + myHandR);

        if (Vector3.Distance(playerTransform.position, CageDoortransform.position) < 5.0f)
        {
            if ((myHandR == "RCut"))
            {
                if (rot > 50)
                {
                    rot = rot - 1;
                    CageDoor.gameObject.transform.rotation = Quaternion.Euler(0.0f, rot, 0.0f);
                    if (!SoundEffects.soundplayed)
                    {
                        SoundEffects.soundplayed = true;
                        SoundEffects.whatSound = 302;
                    }
                }
                if(rot <= 50)
                {
                    SoundEffects.whatSound = 0;
                }
            }
        }

        if((bottleSensor.count == 4) || (buttontouch.buttonpush == 1000))
        {
            CageDoor.gameObject.transform.rotation = Quaternion.Euler(0.0f, 50, 0.0f);
        }
    }
}
