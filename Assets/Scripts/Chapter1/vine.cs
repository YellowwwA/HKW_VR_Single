using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vine : MonoBehaviour
{
    public ParticleSystem deathParticles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnCollisionEnter(Collision collision)
    {   Debug.Log("@@@@@@@�����");
        if(collision.collider.gameObject.CompareTag("poisonbullet"))
        {   
            //SoundEffects.whatSound = 105;
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            Destroy(gameObject, 1f);
        }
    }
}
