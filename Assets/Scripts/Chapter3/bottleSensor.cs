using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottleSensor : MonoBehaviour
{

    public static string bottletouch;
    public static int count;
    public static string prevbottle;
    public static string curbottle;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("bottle"))
        {
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