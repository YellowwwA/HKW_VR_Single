using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottleSensor : MonoBehaviour
{

    public static string bottletouch;
    public static int count;
    public static string prevbottle;
    public static string curbottle;
    //public static int prevbottletouch;
    // Start is called before the first frame update
    void Start()
    {

        count = 0;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("bottle"))
        {
            //prevbottletouch = bottletouch;
            curbottle = "A";
            
            if(curbottle != prevbottle){
                bottletouch = "A";
                prevbottle = "A";
                count ++;
            }
            SoundEffects.whatSound = 305;
        }
        if(collision.CompareTag("bottleB"))
        {
            //prevbottletouch = bottletouch;
            curbottle = "B";
            
            if(curbottle != prevbottle){
                bottletouch = "B";
                prevbottle = "B";
                count ++;
            }
            SoundEffects.whatSound = 305;            
        }
        if(collision.CompareTag("bottleC"))
        {
            //prevbottletouch = bottletouch;
            curbottle = "C";
            
            if(curbottle != prevbottle){
                bottletouch = "C";
                prevbottle = "C";
                count ++;
            }
            SoundEffects.whatSound = 305;            
        }
        if(collision.CompareTag("bottleD"))
        {
            //prevbottletouch = bottletouch;
            curbottle = "D";

            if(curbottle != prevbottle){
                bottletouch = "D";
                prevbottle = "D";
                count ++;
            }
            SoundEffects.whatSound = 305;            
        }
    }
}