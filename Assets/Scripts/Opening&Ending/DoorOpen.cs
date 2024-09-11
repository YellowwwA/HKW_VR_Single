using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    GameObject HouseDoor;
    private float rot;
    public Transform playerTransform;
    public Transform houseDoorTransform;
    private string myHandL;
    private string myHandR;   

    // Start is called before the first frame update
    void Start()
    {
        HouseDoor = GameObject.FindGameObjectWithTag("HouseDoor");
        rot = 0;
        SoundEffects.soundplayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        myHandL = LeftGestureDetector.curHand;
        //Debug.Log("Movement : " + myHandL);
        myHandR = RightGestureDetector.curHand;
        //Debug.Log("Movement : " + myHandR);

        if (Vector3.Distance(playerTransform.position, houseDoorTransform.position) < 2.5f)
        {
            if ((myHandR == "RCut"))
            {
                if (rot > -130)
                {
                    rot = rot - 1;
                    HouseDoor.gameObject.transform.rotation = Quaternion.Euler(0.0f, rot, 0.0f);
                    if (!SoundEffects.soundplayed)
                    {
                        SoundEffects.soundplayed = true;
                        SoundEffects.whatSound = 3;
                    }
                }
                if(rot <= -130)
                {
                    SoundEffects.whatSound = 0;
                }            
            }
        }
    }
}
