using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class AMCH3 : MonoBehaviour
{
        public VideoPlayer vid;
    // Start is called before the first frame update
    void Start()
    {
               vid.loopPointReached += CheckOver;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(8);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
