using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic; // ここコピペ

public class lefttestt : MonoBehaviour {
    //   public AudioSource PunchSE;
    //   public AudioSource MissPunchSE;
    public MainManager main;
    public Animator anim;
    public Text text;
    public bool f;
    public bool f2;
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    int timer;
    public int SoundTimer;
    bool abc;
    GameObject shake;

    GameObject hand;
    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ
        hand = GameObject.Find("Right");
        f = false;
        f2 = false;
        abc = false;
        timer = 0;
        SoundTimer = 1;
        shake = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0) && hand.GetComponent<testtt>().SoundTimer == 1)
        {
            anim.SetTrigger("trg2");

        }
        else anim.ResetTrigger("trg2");

        if (main.HitStop&&f)
        {
            anim.SetTrigger("stop1");
            //Time.timeScale = 0.01f;
            main.HitStop = false;
            timer++;
     
             SoundTimer++;
            
            if (timer > 50)
            {

                //Time.timeScale = 1.0f;
                // timer = 0;
            }
            //t = true;
        }

        else anim.ResetTrigger("stop1");

        if (hand.GetComponent<testtt>().SoundTimer >= 2)
        {
            anim.speed = 0.0f;
            if (hand.GetComponent<testtt>().SoundTimer > 40)
            {
                bool flg = shake.GetComponent<ShakeCamera>().GetShakeFlg();
                if (!flg) shake.GetComponent<ShakeCamera>().CatchShake();
                //audioSource.PlayOneShot(audioClip[0]);  // ここコピペ
                flg = true;
                anim.speed = 1.0f;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (GameManager.GetLorR() == 0)
        {
            //t = true;
            // PunchSE.PlayOneShot(PunchSE.clip);
            text.GetComponent<ComboText>().ComboUpdate();
            //GameManager.AddCombo(1);
            f = true;

            Debug.Log(GameManager.GetCombo());
        }

        else
        {
            // MissPunchSE.PlayOneShot(MissPunchSE.clip);
            GameManager.SetCombo(0);
            f2 = true;

            Debug.Log(GameManager.GetCombo());
        }
 

    }
}
