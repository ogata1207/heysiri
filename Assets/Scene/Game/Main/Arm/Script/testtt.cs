using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic; // ここコピペ

public class testtt : MonoBehaviour {
    public Animator anim;
    //public AudioSource PunchSE;
    //public AudioSource MissPunchSE;
    public Text text;
    public MainManager main;
    public bool f;
    public bool f2;
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    int timer;
    public int SoundTimer;
    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ

        f = false;
        f2 = false;
        timer = 0;
        SoundTimer = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1)&&!main.HitStop)
        {
            anim.SetTrigger("trg");

        }
        else anim.ResetTrigger("trg");

        if (main.HitStop)
        {
            
            //Time.timeScale = 0.01f;
            main.HitStop = false;
            timer++;
        
             SoundTimer++;
            
            if (timer > 50)
            {
               // Time.timeScale = 1.0f;
                // timer = 0;
            }
            //t = true;
        }
        if (SoundTimer >= 2)
        {
            anim.speed = 0.0f;
            if (SoundTimer > 40)
            {
                //audioSource.PlayOneShot(audioClip[0]);  // ここコピペ
                anim.speed = 1.0f;
            }
        }

    }


    //オブジェクトが衝突したとき
    void OnTriggerEnter2D(Collider2D col)
    {
        if (GameManager.GetLorR() == 1)
        {
            // PunchSE.PlayOneShot(PunchSE.clip);
            text.GetComponent<ComboText>().ComboUpdate();
            //GameManager.AddCombo(1);
            f = true;
            Debug.Log(GameManager.GetCombo());
        }
        else
        {
            //  MissPunchSE.PlayOneShot(MissPunchSE.clip);
            GameManager.SetCombo(0);
            f2 = true;
            Debug.Log(GameManager.GetCombo());
        }
    }
}
