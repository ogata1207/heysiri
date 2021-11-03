using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic; // ここコピペ



public class ComboManager : MonoBehaviour
{
    public int 初期の時間 = 2;
    public GameObject RightPanel;
    public GameObject LeftPanel;
    AudioSource audioSource;  // ここコピペ
    public List<AudioClip> audioClip = new List<AudioClip>();  // ここコピペ
    private bool coroutineflg;
    public bool RightActive = true;
    public bool LeftActive = false;
    private int ChangeTime;
    private int SaveTime;
    private int LR = 0;

    int Rtimer;
    int Ltimer;

    // Use this for initialization
    void Start()
    {

        audioSource = gameObject.AddComponent<AudioSource>();  // ここコピペ

        GameManager.SetChangeTime(初期の時間);
        SaveTime = GameManager.GetChangeTime();
        ChangeTime = SaveTime;
        if (coroutineflg == false)
        {
            coroutineflg = true;
            StartCoroutine(Judge());
        }

        if (Random.Range(0, 2) == 0)
        {
            Change();

        }

        Rtimer = 0;
        Ltimer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //GameManager.SetLorR(0);
        GameManager.SetChangeTime(初期の時間);

        if (ChangeTime <= 0)
        {
            ChangeTime = SaveTime;

            //反転
            Change();

        }
        if (!RightActive)
        {
            Rtimer++;
            Ltimer = 0;
            if (Rtimer == 1)
            {
                //audioSource.PlayOneShot(audioClip[0]);  // ここコピペ
            }
        }
        if (!LeftActive)
        {
            Ltimer++;
            Rtimer = 0;
            if (Ltimer == 1)
            {
                //audioSource.PlayOneShot(audioClip[1]);  // ここコピペ
            }
        }
    }
    void Change()
    {
        //反転
        RightActive = !RightActive;
        LeftActive = !LeftActive;
        RightPanel.SetActive(RightActive);
        LeftPanel.SetActive(LeftActive);

        LR = 1 - LR;
        GameManager.SetLorR(LR);
        //if (GameManager.GetLorR() == 0) 
        //else if (GameManager.GetLorR() == 1) 
    }

    IEnumerator Judge()
    {
        while (true)
        {


            {


                if (GameManager.GetLorR() == 0)
                {
                    if (Input.GetMouseButtonDown(1))
                    {
                        GameManager.SetCombo(0);
                    }
                }


                else if (GameManager.GetLorR() == 1)
                {
                    if (Input.GetMouseButton(0))
                    {
                        GameManager.SetCombo(0);
                    }


                }



            }
            yield return new WaitForSeconds(1.0f);
            ChangeTime--;
            Debug.Log("変更までの時間 : " + ChangeTime);
            Debug.Log(GameManager.GetLorR());
        }
    }

}
