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
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ppr"))
        {
            respawnState = 1;
            SoundEffects.whatSound = 207;
        }
    }
}
