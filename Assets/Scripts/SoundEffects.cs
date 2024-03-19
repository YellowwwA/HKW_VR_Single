using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip walk1S; // 101
    [SerializeField] private AudioClip walk2S; // 201
    [SerializeField] private AudioClip walk3S; // 301
    [SerializeField] private AudioClip electricityS; // 001
    [SerializeField] private AudioClip poisonS; // 002
    [SerializeField] private AudioClip doorS; // 003
    [SerializeField] private AudioClip guideS; // 004
    
    [SerializeField] private AudioClip dropS; // 102
    [SerializeField] private AudioClip unpackS; // 103
    [SerializeField] private AudioClip removeVineS; // 105
    [SerializeField] private AudioClip turnOnLightS; // 104
    
    [SerializeField] private AudioClip bridgeUpS; // 202
    [SerializeField] private AudioClip monsterDeathS; // 203
    [SerializeField] private AudioClip getKeyS; // 204
    [SerializeField] private AudioClip unlockS; // 205
    [SerializeField] private AudioClip witchS; // 206
    [SerializeField] private AudioClip waterS; // 207
    
    [SerializeField] private AudioClip cageDoorS; // 302
    [SerializeField] private AudioClip ovenButtonS; // 303
    [SerializeField] private AudioClip oven1000S; // 304
    [SerializeField] private AudioClip pourS; // 305
    [SerializeField] private AudioClip poisonPotionS; // 306
    [SerializeField] private AudioClip swingBroomS; // 307
    [SerializeField] private AudioClip brokenBroomS; // 308

    public static int whatSound = 0;
    public static bool soundplayed;

    public float volume = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //audioSource.Play();
        // ���� -
        if (whatSound == 1)
        {
            audioSource.PlayOneShot(electricityS, volume);
            whatSound = 0;
        }
        // �� -
        if (whatSound == 2)
        {
            audioSource.PlayOneShot(poisonS, volume);
            whatSound = 0;
        }
        if (whatSound == 3)
        {
            audioSource.PlayOneShot(doorS, volume);
            whatSound = 0;
        }
        if (whatSound == 4)
        {
            audioSource.PlayOneShot(guideS, volume);
            whatSound = 0;
        }
        /***Chapter1***/
        // �ٱ��� -
        if (whatSound == 102)
        {
            audioSource.PlayOneShot(dropS, volume);
            whatSound = 0;
        }
        // ������
        if (whatSound == 103)
        {
            audioSource.PlayOneShot(unpackS, volume);
            whatSound = 0;
        }
        // ���ε� ��
        if (whatSound == 104)
        {
            audioSource.PlayOneShot(turnOnLightS, volume);
            whatSound = 0;
        }
        if (whatSound == 105)
        {
            audioSource.PlayOneShot(removeVineS, volume);
            whatSound = 0;
        }
        /***Chapter2***/
        // ���ݸ� �ٸ�
        if (whatSound == 202)
        {
            audioSource.PlayOneShot(bridgeUpS, volume);
            whatSound = 0;
        }
        // ������ ��ġ
        if (whatSound == 203)
        {
            audioSource.PlayOneShot(monsterDeathS, volume);
            whatSound = 0;
        }
        // ���� ȹ��
        if (whatSound == 204)
        {
            audioSource.PlayOneShot(getKeyS, volume);
            whatSound = 0;
        }
        // �ڹ��� ����
        if (whatSound == 205)
        {
            audioSource.PlayOneShot(unlockS, volume);
            whatSound = 0;
        }
        // ���� ���� -
        if (whatSound == 206)
        {
            audioSource.PlayOneShot(witchS, volume);
            whatSound = 0;
        }

        if (whatSound == 207)
        {
            audioSource.PlayOneShot(waterS, volume);
            whatSound = 0;
        }
        /***Chapter3***/
        if (whatSound == 302)
        {
            audioSource.PlayOneShot(cageDoorS, volume);
            whatSound = 0;
        }
        // ������ ��ġ
        if (whatSound == 303)
        {
            audioSource.PlayOneShot(ovenButtonS, volume);
            whatSound = 0;
        }
        // ���� ȹ��
        if (whatSound == 304)
        {
            audioSource.PlayOneShot(oven1000S, volume);
            whatSound = 0;
        }
        // �ڹ��� ����
        if (whatSound == 305)
        {
            audioSource.PlayOneShot(pourS, volume);
            whatSound = 0;
        }
        // ���� ���� -
        if (whatSound == 306)
        {
            audioSource.PlayOneShot(poisonPotionS, volume);
            whatSound = 0;
        }
        if (whatSound == 307)
        {
            audioSource.PlayOneShot(swingBroomS, volume);
            whatSound = 0;
        }
        if (whatSound == 308)
        {
            audioSource.PlayOneShot(brokenBroomS, volume);
            whatSound = 0;
        }        
    }
}