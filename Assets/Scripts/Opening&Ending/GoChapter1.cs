using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoChapter1 : MonoBehaviour
{
    // Update is called once per frame
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
