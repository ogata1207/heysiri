using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour {

    //
    public float Magnification = 1.0f;     //倍率


    //ここでしかつかわんやつ
    private Color color;    //元のRGBの保存用

    // Use this for initialization
    void Start () {
        color = GetComponent<Image>().color;
       // color.a = 255.0f;
        //Alphaの更新を開始する
       StartCoroutine(AlphaUpdate());

    }
	
	// Update is called once per frame
	void Update () {
        //lpha--;
        
    }

    IEnumerator AlphaUpdate()
    {
        float time = Time.time;
        while (true)
        {
            GetComponent<Image>().color = new Color(color.r, color.g, color.b, color.a);
            color.a -= 0.1f * Magnification;
            yield return null;
        }
    }
}
