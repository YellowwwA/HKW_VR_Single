using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonScript : MonoBehaviour
{
    public GameObject poisonBall;
    public GameObject electricBall;
    public float shootForce = 0f;

    private string myHandL;
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
        myHandR = RightGestureDetector.curHand;

        if (!myHandR.Equals(previousGesture))
        {
            //previousGesture = myHand;
            if ((myHandL == "LRock") && (myHandR == "RGoahead"))
            {
                GameObject projectile = (GameObject)Instantiate(
                    poisonBall, transform.position, transform.rotation);
                projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * shootForce);
                /*
                if (!SoundEffects.soundplayed)
                {
                    SoundEffects.soundplayed = true;
                    SoundEffects.whatSound = 2;
                }*/
            }
            if ((myHandL == "LCut") && (myHandR == "RGoahead"))
            {
                GameObject projectile = (GameObject)Instantiate(
                    electricBall, transform.position, transform.rotation);
                projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * shootForce);
            }
            /*
            if (!SoundEffects.soundplayed)
            {
                SoundEffects.soundplayed = true;
                SoundEffects.whatSound = 1;
            }*/
        }
    }
}
