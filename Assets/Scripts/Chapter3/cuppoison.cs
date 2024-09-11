using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cuppoison : MonoBehaviour
{
    Vector3 targetA = new Vector3(9.86f, 5.54f, -5.05f);
    Vector3 targetB = new Vector3(9.86f, 5.64f, -5.05f);
    Vector3 targetC = new Vector3(9.86f, 5.74f, -5.05f);
    Vector3 targetD = new Vector3(9.86f, 5.8f, -5.05f);

    // Update is called once per frame
    void Update()
    {
        if(bottleSensor.count == 1){
            transform.position = Vector3.MoveTowards(transform.position, targetA, 0.5f);
        }
        if(bottleSensor.count == 2){
            transform.position = Vector3.MoveTowards(transform.position, targetB, 0.5f);
        }
        if(bottleSensor.count == 3){
            transform.position = Vector3.MoveTowards(transform.position, targetC, 0.5f);
        }
        if(bottleSensor.count == 4){
            transform.position = Vector3.MoveTowards(transform.position, targetD, 0.5f);
            Invoke("sceneChange",4);
        }
    }

    void sceneChange()
    {
        SoundEffects.whatSound = 306;
        SceneManager.LoadScene(8);
    }

}