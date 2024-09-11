using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGuide : MonoBehaviour
{
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
