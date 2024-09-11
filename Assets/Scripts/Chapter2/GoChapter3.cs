using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoChapter3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("sceneChange",2);
    }

    void sceneChange()
    {
        SceneManager.LoadScene(7);
    }
}
