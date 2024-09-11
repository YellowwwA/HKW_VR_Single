using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenBroom : MonoBehaviour
{
    //public GameObject tapePrefab;
    public GameObject BrokenBroomPrefab;
    bool tape;

    // Start is called before the first frame update
    void Start()
    {
        tape = false;
        SoundEffects.soundplayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(DestroyBroom.cutCount == 300 )
        {
            DestroyBroom.broken = true;
            if(tape == false)
            {
                Destroy(gameObject, 0.1f);
                Instantiate(BrokenBroomPrefab, new Vector3(-7.3811f, 5.6751f, 16.617f), Quaternion.Euler(0, 0, 2.282f));
                
                SoundEffects.whatSound = 308;
                tape = true;
            }
            
            //Debug.Log("BroomStick is broken!");
        }
    }
}
