using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QdestroyOven : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(buttontouch.buttonpush == 1000){
            Destroy(gameObject);
        }
    }
}
