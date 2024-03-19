using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//struct = class without function
[System.Serializable]
public struct GestureR
{
    public string name;
    public List<Vector3> fingerDatas;
    public UnityEvent onRecognized;
}

public class RightGestureDetector : MonoBehaviour
{
    //public PlayerController player;
    public float threshold = 0.1f;
    public OVRSkeleton skeleton;
    public List<GestureR> gestures;
    public bool debugMode = true;
    private List<OVRBone> fingerBones;
    private GestureR previousGesture;
    //test
    public static string curHand;

    //chapter1
    public Transform basketTransform;
    public Transform cameraTransform;
    


    // Start is called before the first frame update
    void Start()
    {
        fingerBones = new List<OVRBone>(skeleton.Bones);
        previousGesture = new GestureR();
    }

    // Update is called once per frame
    void Update()
    {
        if(debugMode && Input.GetKeyDown(KeyCode.Tab))
        {
            fingerBones = new List<OVRBone>(skeleton.Bones);
            Save();
        }

        if (fingerBones.Count == 0)
        {
            fingerBones = new List<OVRBone>(skeleton.Bones);
        }

        GestureR currentGesture = Recognize();
        bool hasRecognized = !currentGesture.Equals(new GestureR());
        if(hasRecognized && !currentGesture.Equals(previousGesture))
        {
            Debug.Log("New Gesture Found : " + currentGesture.name);
            previousGesture = currentGesture;
            //test
            curHand = currentGesture.name;

            if(currentGesture.name == "RCut")
            {
                //Debug.Log("111111RopeCut Start!!");
                RopeCut();
            } //chapter1
        
            currentGesture.onRecognized.Invoke();
        }
    }

    void Save()
    {
        GestureR g = new GestureR();
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

    GestureR Recognize()
    {
        GestureR currentgesture = new GestureR();
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
    //chapter1
    private void RopeCut()
    {

        //Debug.Log("222222position distance!!");
        if (Vector3.Distance(cameraTransform.position, basketTransform.position) < 2.0f)
        {
            //Debug.Log("3333position");
            //basketTransform.Translate(new Vector3(0, -1.046f, 0) * 5.0f * Time.deltaTime);
            SoundEffects.whatSound = 102;
            basketTransform.position = new Vector3(157.968f, 0.21f, 39.074f);
        }
    }
}
