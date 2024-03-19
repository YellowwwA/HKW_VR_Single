using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class AMCH2 : MonoBehaviour
{
    public VideoPlayer vid;

    // Start is called before the first frame update
    void Start()
    {
       vid.loopPointReached += CheckOver;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
