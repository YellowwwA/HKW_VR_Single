using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class lastpprattack : MonoBehaviour
{
    public ParticleSystem deathParticles;

    public GameObject witchPrefab;
    public static int witchState;
    public GameObject Target;


    public void OnCollisionEnter(Collision collision)
    {
        if((collision.collider.gameObject.CompareTag("poisonbullet")) || (collision.collider.gameObject.CompareTag("electricbullet")))
        {   
            SoundEffects.whatSound = 206;
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            
            Vector3 pos = gameObject.transform.position;
            Quaternion targetRot = Quaternion.LookRotation(transform.position);

            //Destroy(gameObject, 2f);
            Destroy(gameObject);

            if (witchState == 0)
            {
                witchState = 1;
                Instantiate(witchPrefab, new Vector3(pos.x, 18f, pos.z), Quaternion.Euler(0, 160, 0));
                witchPrefab.transform.rotation = Quaternion.Lerp(witchPrefab.transform.rotation, targetRot,1f);
            }                                                               //�Ųٷ� ȸ���Ѵٸ� -�ٿ�����
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        witchState = 0;
    }

    // Update is called once per frame
    void Update()
    {


    }
}
