using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGuide : MonoBehaviour
{
    public Transform playerTransform;
    public Transform ButtonTransform;

    public static int show;
    public static int removeGuide;
    public static int removeGuide2;
    public static int removeGuide3;
    public GameObject guidePrefab1;
    public GameObject guidePrefab2;
    public GameObject guidePrefab3;

    private string myHandR;

    // Start is called before the first frame update
    void Start()
    {
        show = 0;
        removeGuide = 0;
        removeGuide2 = 0;
        removeGuide3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        myHandR = RightGestureDetector.curHand;

        if (Vector3.Distance(playerTransform.position, ButtonTransform.position) < 1.3f)
        {
            if ((myHandR == "RPaper"))
            {
                if(show ==0)
                {   
                    //transform.Translate(152.273f, 0.08f, 25.10616f);
                    show = 1;
                    Instantiate(guidePrefab1, new Vector3(153.42f, -0.24f, 31.11f), Quaternion.Euler(0, 22.643f, 0));
                    Instantiate(guidePrefab2, new Vector3(151.67f, -0.24f, 45.73f), Quaternion.Euler(0, -37.082f, 0));
                    Instantiate(guidePrefab3, new Vector3(150.66f, -0.24f, 56.82f), Quaternion.Euler(0, 56.279f, 0));
                }
            }
            if ((myHandR == "RRock"))
            {
                if (show == 1)
                {
                    //transform.Translate(152.273f, 0.081f, 25.10616f);
                    removeGuide = 1;
                    removeGuide2 = 1;
                    removeGuide3 = 1;
                }
            }
        }
    }
}
