using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{   //@@@@chapter1->ch2Animation

    //public string transferMapName;
    //private Player thePlayer;


    // Start is called before the first frame update
    void Start()
    {
        //if(thePlayer == null)
        //thePlayer = FindObjectOfType<Player>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(5);
        }
    }
}
