using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnLeft : MonoBehaviour
{
    public Transform LightsOnTransform;
    /*
    public ParticleSystem lightParticles;
    public void OnCollisionEnter(Collision collision)
    {Debug.Log("LLLLL@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        if(collision.gameObject.CompareTag("electricbullet"))
        {   Debug.Log("LLLLLLLLLLLL@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Instantiate(lightParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
            //LightsOnTransform.Translate(0f, 5.0f, 0f);
            LightsOnTransform.position = new Vector3(155.67f,0f,59.89f);

        }
    }*/

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("electricbullet"))
        {
            Destroy(gameObject);
            LightsOnTransform.position = new Vector3(155.67f,0f,59.89f);
            SoundEffects.whatSound = 104;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
