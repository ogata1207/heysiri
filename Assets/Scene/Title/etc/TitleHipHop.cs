using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic; // ここコピペ

public class TitleHipHop : MonoBehaviour
{
    public Animator anim;
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    bool f;
    public bool TimerF;
    public int ChangeTimer;
    void Start()
    {
        f = false;
        TimerF = false;
        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ
        ChangeTimer = 0;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "RightArm")
        {

            TimerF = true;
            f = true;
            audioSource.PlayOneShot(audioClip[0]);  // ここコピペ


        }
        else
        {
            f = false;
        }
    }

    void Update()
    {
        if (TimerF)
        {
            ChangeTimer++;
        }

        if (f)
        {
            anim.SetTrigger("New");
            f = false;
        }
        else
        {
            anim.ResetTrigger("New");
        }
    }

}
