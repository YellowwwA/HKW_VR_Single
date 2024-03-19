using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    public Transform LightsOnTransform;

//    public ParticleSystem lightParticles;
   /* public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("1@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        if(collision.gameObject.CompareTag("electricbullet"))
        {   
            Debug.Log("touch@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Instantiate(lightParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
            //LightsOnTransform.Translate(0f, 5.0f, 0f);
            LightsOnTransform.position = new Vector3(155.72f,0f,54.24f);

        }
    }*/

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("electricbullet"))
        {
            Destroy(gameObject);
            LightsOnTransform.position = new Vector3(155.72f,0f,54.24f);
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
