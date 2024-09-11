using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnLeft : MonoBehaviour
{
    public Transform LightsOnTransform;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("electricbullet"))
        {
            Destroy(gameObject);
            LightsOnTransform.position = new Vector3(155.67f,0f,59.89f);
            SoundEffects.whatSound = 104;
        }
    }
}
