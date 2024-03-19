using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qdestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(bottleSensor.count == 4){
            Destroy(gameObject);
       }
    }
}
