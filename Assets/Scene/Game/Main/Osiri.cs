using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic; // ここコピペ

public class Osiri : MonoBehaviour {
    GameObject a;
    GameObject b;
    public AudioSource PunchSE;
    public AudioSource MissPunchSE;
    public Slider slider;
    public Animator anim;
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    public int おしりの強度 = 1;
    GameObject shake;
    public MainManager main;
    public int ダメージ;
    int tttt;
    public bool yaju;
    void Start()
    {
        yaju = false;
        a = GameObject.Find("Left");
        b = GameObject.Find("Right");
        shake = GameObject.Find("Main Camera");
        tttt = 0;
        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ
    }
    void Update()
    {

        if (b.GetComponent<testtt>().SoundTimer > 2)
        {
            anim.speed = 0.0f;
            tttt++;
            if (b.GetComponent<testtt>().SoundTimer > 40)
            {
                anim.speed = 1.0f;
                if(tttt> 30)
                {
                    yaju = true;
                    audioSource.PlayOneShot(audioClip[4]);  // ここコピペ
                    tttt = 0;
                }
            }
        }
    }

    void Awake()
    {
        float health = GameManager.GetSliderHealth();
        GameManager.SetSliderHealth(health * おしりの強度);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        bool flg = shake.GetComponent<ShakeCamera>().GetShakeFlg();
        if (!flg) shake.GetComponent<ShakeCamera>().CatchShake();
        if (col.tag == "RightArm")
        {
            if (GameManager.GetLorR() == 1)
            {
                flg = true;
                PunchSE.PlayOneShot(PunchSE.clip);
                if (b.GetComponent<testtt>().SoundTimer == 1)
                {
                    audioSource.PlayOneShot(audioClip[0]);  // ここコピペ
                }
                StartCoroutine(tst());
                slider.value += ダメージ + ( GameManager.GetCombo() * 3f );
                anim.SetTrigger("Right");
            }
            else
            {
                MissPunchSE.PlayOneShot(MissPunchSE.clip);
                audioSource.PlayOneShot(audioClip[2]);  // ここコピペ
                anim.ResetTrigger("Right");
                StartCoroutine(Zoom());
            }
        }

        if(col.tag == "LeftArm")
        {
            if (GameManager.GetLorR() == 0)
            {
                flg = true;

                PunchSE.PlayOneShot(PunchSE.clip);
                if (a.GetComponent<lefttestt>().SoundTimer == 1)
                {
                    audioSource.PlayOneShot(audioClip[1]);  // ここコピペ
                }
                slider.value += ダメージ + (GameManager.GetCombo() * 3f);
                anim.SetTrigger("Left");
            }
            else
            {
                MissPunchSE.PlayOneShot(MissPunchSE.clip);
                audioSource.PlayOneShot(audioClip[3]);  // ここコピペ
                anim.ResetTrigger("Left");
                StartCoroutine(Zoom());
            }
        }
    }

    IEnumerator tst()
    {
        //Time.timeScale = 0.1f;
        //yield return new WaitForSeconds(0.2f);
        //Time.timeScale = 0.2f;
        //yield return new WaitForSeconds(0.00002f);
        //Time.timeScale = 1.0f;
        yield return null;
    }


    IEnumerator Zoom()
    {
        GameObject camera = GameObject.FindWithTag("MainCamera");
        float size = camera.GetComponent<Camera>().orthographicSize;
        while (size > 1.6f)
        {
            size -= 0.15f;
            camera.GetComponent<Camera>().orthographicSize = size;
            yield return null;
        }
     
        yield return null;

        camera.GetComponent<Camera>().orthographicSize = 5.0f;
        yield return null;
    }

    IEnumerator SpriteZoom()
    {
        Vector3 scale = transform.localScale;
        GetComponent<BoxCollider2D>().enabled = false;
        yield return null;
        while(transform.localScale.x < 2.5)
        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0);
            yield return new WaitForSeconds(0.0f);
        }
        yield return null;
        GetComponent<BoxCollider2D>().enabled = true;
        transform.localScale = scale;
    }
}
