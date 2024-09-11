using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttontouch : MonoBehaviour
{
    public static int buttonpush = 0;

    // Update is called once per frame
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("button"))
        {
            SoundEffects.whatSound = 303;
            buttonpush += 100;

            if(buttonpush == 1000)
            {
                SoundEffects.whatSound = 304;
            }
        }
    }
}
