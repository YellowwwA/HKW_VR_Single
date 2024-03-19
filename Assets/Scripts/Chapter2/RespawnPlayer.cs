using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public static int respawnState;
    // Start is called before the first frame update
    void Start()
    {
        respawnState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
/*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ppr")
        {
            Debug.Log("Reset");
            respawnState = 1;
            //SoundEffect.whatSound = 1;
        }
    }
*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ppr")
        {
            Debug.Log("Water");
            respawnState = 1;
            SoundEffects.whatSound = 207;
        }
    }
}
