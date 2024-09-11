using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHelpGuide : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (ShowHelpGuide.removeGuide == 1)
        {
            Destroy(gameObject);
            ShowHelpGuide.removeGuide = 0;
            ShowHelpGuide.show = 0;
        }
    }
}
