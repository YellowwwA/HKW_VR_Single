using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private GameObject respawn;
    // Start is called before the first frame update
    void Start()
    {
        respawn = GameObject.FindGameObjectWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        if (RespawnPlayer.respawnState == 1)
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = respawn.transform.position;
            GetComponent<CharacterController>().enabled = true;

            RespawnPlayer.respawnState = 0;
        }
    }
}
