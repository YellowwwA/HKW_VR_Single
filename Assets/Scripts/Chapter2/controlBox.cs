using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlBox : MonoBehaviour
{
    public static string ChocoBridgeUp = "false";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {   Debug.Log("@@@@@@@");
        if(collision.CompareTag("electricbullet"))
        {
            Debug.Log("222222222222@@");
            if(ChocoBridgeUp == "false")
            {
                SoundEffects.whatSound = 202;
                ChocoBridgeUp = "true";
            }
        }
    }
}
