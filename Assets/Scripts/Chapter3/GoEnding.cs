using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoEnding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SoundEffects.whatSound = 0;
        if((bottleSensor.count == 4) && (DestroyBroom.cutCount == 300) && (buttontouch.buttonpush == 1000))
        {
            Invoke("sceneChange",2);
        }
    }

    void sceneChange()
    {
        SceneManager.LoadScene(11);
    }
}
