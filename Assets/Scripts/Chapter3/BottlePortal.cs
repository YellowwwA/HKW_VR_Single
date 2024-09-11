using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottlePortal : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(10);
        }
    }
    void Update()
    {
        if(bottleSensor.count == 4){
            Destroy(gameObject,2f);
        }
    }
}
