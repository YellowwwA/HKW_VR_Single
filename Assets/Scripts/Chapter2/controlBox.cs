using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlBox : MonoBehaviour
{
    public static string ChocoBridgeUp = "false";

    private void OnTriggerEnter(Collider collision)
    {   
        if(collision.CompareTag("electricbullet"))
        {
            if(ChocoBridgeUp == "false")
            {
                SoundEffects.whatSound = 202;
                ChocoBridgeUp = "true";
            }
        }
    }
}
