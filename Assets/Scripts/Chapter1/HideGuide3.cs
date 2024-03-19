using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGuide3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShowGuide.removeGuide3 == 1)
        {
            Destroy(gameObject);
            ShowGuide.removeGuide3 = 0;
            ShowGuide.show = 0;
        }
    }
}
