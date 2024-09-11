using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QdestroyBroom : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(DestroyBroom.cutCount == 300 ){
            Destroy(gameObject);
        }
    }
}
