using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGuide2 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (ShowGuide.removeGuide2 == 1)
        {
            Destroy(gameObject);
            ShowGuide.removeGuide2 = 0;
            ShowGuide.show = 0;
        }
    }
}
