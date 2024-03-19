using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeUp : MonoBehaviour
{
   private string chocobridge;
    Vector3 target = new Vector3(101, 13.5f, 29);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        chocobridge = controlBox.ChocoBridgeUp;
        if(controlBox.ChocoBridgeUp == "true"){
            transform.position = Vector3.MoveTowards(transform.position, target, 0.2f);
            SoundEffects.whatSound = 0;            
        }
    }
}
