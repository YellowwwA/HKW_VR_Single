using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ovenTemperture : MonoBehaviour
{
    public Text text;
    public static string ovenfire;
    
    // Update is called once per frame
    void Update()
    {
        //degree = buttontouch.buttonpush;
        text.text = buttontouch.buttonpush.ToString() + "℃";
        if(buttontouch.buttonpush == 1000){
            //ovenfire = "fireup";
            SceneManager.LoadScene(8);
            ovenfire = "fireup";
        }
    }

}
