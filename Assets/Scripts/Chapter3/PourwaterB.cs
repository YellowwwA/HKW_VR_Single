using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourwaterB : MonoBehaviour
{

    private string cursensor;

    // Update is called once per frame
    void Update()
    {
        cursensor = bottleSensor.bottletouch;

        if(cursensor == "B")
        {  
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(new Vector3(120.0f,0,0)),0.02f);
            Destroy(gameObject,5f);
        }


    }
}
