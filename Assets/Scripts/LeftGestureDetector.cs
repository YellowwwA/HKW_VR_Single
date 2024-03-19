using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//struct = class without function
[System.Serializable]
public struct GestureL
{
    public string name;
    public List<Vector3> fingerDatas;
    public UnityEvent onRecognized;
}

public class LeftGestureDetector : MonoBehaviour
{
    //public PlayerController player;
    public float threshold = 0.1f;
    public OVRSkeleton skeleton;
    public List<GestureL> gestures;
    public bool debugMode = true;
    private List<OVRBone> fingerBones;
    private GestureL previousGesture;
    //test
    public static string curHand;

    /*chapter1
    public Transform basketTransform;
    public Transform cameraTransform;
    */


    // Start is called before the first frame update
    void Start()
    {
        fingerBones = new List<OVRBone>(skeleton.Bones);
        previousGesture = new GestureL();
    }

    // Update is called once per frame
    void Update()
    {
        if(debugMode && Input.GetKeyDown(KeyCode.Space))
        {
            fingerBones = new List<OVRBone>(skeleton.Bones);
            Save();
        }

        if (fingerBones.Count == 0)
        {
            fingerBones = new List<OVRBone>(skeleton.Bones);
        }

        GestureL currentGesture = Recognize();
        bool hasRecognized = !currentGesture.Equals(new GestureL());
        if(hasRecognized && !currentGesture.Equals(previousGesture))
        {
            Debug.Log("New Gesture Found : " + currentGesture.name);
            previousGesture = currentGesture;
            //test
            curHand = currentGesture.name;

        /*    if(currentGesture.name == "Cut")
            {
                //Debug.Log("111111RopeCut Start!!");
                RopeCut();
            }*/

            currentGesture.onRecognized.Invoke();
        }
    }

    void Save()
    {
        GestureL g = new GestureL();
        g.name = "New Gesture";
        List<Vector3> data = new List<Vector3>();
        foreach(var bone in fingerBones)
        {
            //finger position relative to root
            data.Add(skeleton.transform.InverseTransformPoint(bone.Transform.position));
        }

        g.fingerDatas = data;
        gestures.Add(g);
    }

    GestureL Recognize()
    {
        GestureL currentgesture = new GestureL();
        float currentMin = Mathf.Infinity;

        foreach(var gesture in gestures)
        {
            float sumDistance = 0;
            bool isDiscarded = false;
            for(int i = 0; i < fingerBones.Count; i++)
            {
                Vector3 currentData = skeleton.transform.InverseTransformPoint(fingerBones[i].Transform.position);
                float distance = Vector3.Distance(currentData, gesture.fingerDatas[i]);
                if(distance > threshold)
                {
                    isDiscarded = true;
                    break;
                }

                sumDistance += distance;
            }
            if(!isDiscarded && sumDistance < currentMin)
            {
                currentMin = sumDistance;
                currentgesture = gesture;
            }
        }
        return currentgesture;
    }
    /*private void RopeCut()    //chapter1code
    {

        //Debug.Log("222222position distance!!");
        if (Vector3.Distance(cameraTransform.position, basketTransform.position) < 2.0f)
        {
            //Debug.Log("3333position");
            //basketTransform.Translate(new Vector3(0, -1.046f, 0) * 5.0f * Time.deltaTime);
            basketTransform.position = new Vector3(157.968f, 0.21f, 39.074f);
        }
    }*/
}
