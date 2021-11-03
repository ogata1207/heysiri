using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArm : MonoBehaviour {
    public float Speed = 1.0f;
    public float Acceleration = 1.5f;
    public AudioSource PunchSE;
    public AudioSource MissPunchSE;
    private bool useFlg()  //今腕を使っている時はtrue
    {
        if (transform.position == SavePosition) return false;
        return true;
    }

    private Vector3 SavePosition;   //

    // Use this for initialization
    void Start()
    {
        //腕のポジションを保存
        SavePosition = transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        if (!useFlg() && Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Move2());
           
        }
    }

    //画面外まで振り切る
    IEnumerator Move()
    {
        float speed = Speed;
        while (transform.position.x < 20)
        {
            transform.position += new Vector3(speed, 0, 0);
            speed *= Acceleration;
            yield return null;
        }
        transform.position = SavePosition;
    }

    //画面の中央まで行ってもとの位置に戻る
    IEnumerator Move2()
    {
        float speed = Speed;

        if (GameManager.GetLorR() == 0)
        {
            PunchSE.PlayOneShot(PunchSE.clip);
            GameManager.AddCombo(1);
            Debug.Log(GameManager.GetCombo());
        }
        else
        {
            MissPunchSE.PlayOneShot(MissPunchSE.clip);
            GameManager.SetCombo(0);
            Debug.Log(GameManager.GetCombo());
        }


        //中央まで移動
        while (transform.position.x < 0)
        {
            transform.position += new Vector3(speed, 0, 0);
            speed *= Acceleration;
            yield return null;
        }

        speed = Speed;

        //元の位置まで移動
        while (transform.position.x > SavePosition.x)
        {
            transform.position -= new Vector3(speed, 0, 0);
            speed *= Acceleration;
            yield return null;
        }

        //誤差修正
        transform.position = SavePosition;
    }

}
