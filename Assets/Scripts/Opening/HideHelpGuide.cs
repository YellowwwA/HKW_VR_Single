using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideHelpGuide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
