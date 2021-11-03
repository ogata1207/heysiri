using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic; // ここコピペ

public class TitleHand : MonoBehaviour
{
    public Animator anim;
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            anim.SetTrigger("trg");

        }
        else anim.ResetTrigger("trg");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "TitleHip")
        {
            audioSource.PlayOneShot(audioClip[0]);  // ここコピペ

        }
    }
}
