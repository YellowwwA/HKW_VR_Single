using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovenfireup : MonoBehaviour
{
    public Transform Lights;

    // Update is called once per frame
    void Update()
    {
        if(ovenTemperture.ovenfire == "fireup"){
            Lights.position = new Vector3(21.5f,-0.2f, -1.5f);
        }
    }
}
