using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourwaterB : MonoBehaviour
{

    private string cursensor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cursensor = bottleSensor.bottletouch;

        if(cursensor == "B")
        {  /*
            transform.Rotate(new Vector3(120.0f,0, 0));
           
            Destroy(gameObject,3f);*/
            //Debug.Log("destroy 4444");
            
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(new Vector3(120.0f,0,0)),0.02f);
            Destroy(gameObject,5f);
        }


    }
}
