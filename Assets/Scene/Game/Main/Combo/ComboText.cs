using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboText : MonoBehaviour {

    private Text text;
    private bool MotionFlg;
    public int FontSize = 120;

    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.GetCombo() <= 30)
        {
            text.color = new Color(0f / 255f, 0f / 255f, 0f / 255f);
        }
        if (GameManager.GetCombo() >= 30)
        {
            text.color = new Color(255f / 255f, 20f / 255f, 147f / 255f);
        }

        if (GameManager.GetCombo() >= 50)
        {
            text.color = new Color(255f / 255f, 0f / 255f, 0f / 255f);
        }

        text.text = GameManager.GetCombo() + "Combo";
	}
    public void ComboUpdate()
    {
        GameManager.AddCombo(1);
        if(!MotionFlg)StartCoroutine(Combo());

    }

    IEnumerator Combo()
    {
        int TextSize = text.fontSize;
        MotionFlg = true;
      //  Debug.Log("おれのたーん");
        while (text.fontSize < FontSize)
        {
            text.fontSize += 20;
            yield return null;
        }
     //   Debug.Log("いんたーばる");
        while (text.fontSize > TextSize)
        {
            text.fontSize -= 20;
            yield return null;
        }
       // Debug.Log("たーんえんど");
        text.fontSize = TextSize;
        MotionFlg = false;
    }
}
