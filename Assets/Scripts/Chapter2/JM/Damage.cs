using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public static int life;
    // Start is called before the first frame update
    void Start()
    {
        life = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ppr")
        {
            Debug.Log("Damage");
            life -= 1;
        }
    }
}
