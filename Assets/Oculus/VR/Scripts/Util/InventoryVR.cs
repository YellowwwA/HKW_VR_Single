// Script name: InventoryVR
// Script purpose: attaching a gameobject to a certain anchor and having the ability to enable and disable it.
// This script is a property of Realary, Inc

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryVR : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Anchor;
    bool UIActive;

    private string myHandL;
    private string myHandR;
    private string previousGesture;
    public static bool slotOn = false;

    private void Start()
    {
        Inventory.SetActive(false);
        UIActive = false;
        previousGesture = "None";
    }

    private void Update()
    {
        myHandL = LeftGestureDetector.curHand;
        myHandR = RightGestureDetector.curHand;

        if (!myHandL.Equals(previousGesture))
        {
            if ((myHandL == "LCut")&&(myHandR == "RCut"))
            {
                UIActive = !UIActive;
                Inventory.SetActive(UIActive);
                slotOn = !slotOn;
                //Debug.Log(slotOn + "@@@@@@");
            }
            if (UIActive)
            {
                Inventory.transform.position = Anchor.transform.position;
                Inventory.transform.eulerAngles = new Vector3(Anchor.transform.eulerAngles.x + 15, Anchor.transform.eulerAngles.y, 0);
            }
        }

    }
}