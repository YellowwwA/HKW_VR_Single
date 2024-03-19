using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterRespawn : MonoBehaviour
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Water");
            respawnState = 1;
            SoundEffects.whatSound = 207;
        }
    }
}
