using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGuide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShowGuide.removeGuide == 1)
        {
            Destroy(gameObject);
            ShowGuide.removeGuide = 0;
            ShowGuide.show = 0;
        }
    }
}
