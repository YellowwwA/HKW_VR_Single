using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHelpGuide : MonoBehaviour
{
    public Transform playerTransform;
    public Transform ButtonTransform;

    public static int show;
    public static int removeGuide;
    public GameObject HelpPrefab;

    // Start is called before the first frame update
    void Start()
    {
        show = 0;
        removeGuide = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(playerTransform.position, ButtonTransform.position) <= 1.5f)
        {
            //if (Input.GetKey(KeyCode.Space))
            {
                if (show == 0)
                {
                    show = 1;
                    Instantiate(HelpPrefab, new Vector3(69.48896f, 17.3f, 69.98f), Quaternion.Euler(0, 0, 0));
                }
            }

        }
        else
        {
            if (show == 1)
            {
                removeGuide = 1;
            }
        }
    }
}
