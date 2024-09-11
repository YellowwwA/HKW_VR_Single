using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundEffects.whatSound = 205;
        Destroy(gameObject, 2.0f);
    }
}
