using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    public Transform LightsOnTransform;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("electricbullet"))
        {
            Destroy(gameObject);
            LightsOnTransform.position = new Vector3(155.72f,0f,54.24f);
            SoundEffects.whatSound = 104;
        }
    }
}
