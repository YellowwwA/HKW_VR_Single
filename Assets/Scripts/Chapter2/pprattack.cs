using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pprattack : MonoBehaviour
{
    public ParticleSystem deathParticles;

    public GameObject keyPrefab;
    public static int keyState;


    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.CompareTag("poisonbullet") || collision.collider.gameObject.CompareTag("electricbullet"))
        {   
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            
            Vector3 pos = gameObject.transform.position;

            //Destroy(gameObject, 2f);
            Destroy(gameObject);

            if (keyState == 0)
            {
                //keyState = 1;
                SoundEffects.whatSound = 203;
                Instantiate(keyPrefab, new Vector3(pos.x, 15.5f, pos.z), Quaternion.Euler(-36, 30, -20));
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        keyState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
