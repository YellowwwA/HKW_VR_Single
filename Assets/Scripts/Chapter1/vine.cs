using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vine : MonoBehaviour
{
    public ParticleSystem deathParticles;
 
    public void OnCollisionEnter(Collision collision)
    {   
        if(collision.collider.gameObject.CompareTag("poisonbullet"))
        {   
            //SoundEffects.whatSound = 105;
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            Destroy(gameObject, 1f);
        }
    }
}
