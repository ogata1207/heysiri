using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    GameObject b;
    Text tx;
    // Use this for initialization
    void Start () {
        b = GameObject.Find("Right");

        StartCoroutine(CountDown());
        tx = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        //if(Input.GetKeyDown(KeyCode.O))
        //{
        //    StopCoroutine(CountDown());
        //    StartCoroutine(CountDown());
        //}
        GetComponent<Text>().text = "" + GameManager.GetTimeLimit();

        if (GameManager.GetTimeLimit() <= 30)
        {
            tx.color = new Color(255f / 255f, 140f / 255f, 0f / 255f);
        }

        if (GameManager.GetTimeLimit() <= 15)
        {
            tx.color = new Color(128f / 255f, 0f / 255f, 0f / 255f);
        }
    }

    IEnumerator CountDown()
    {
        while(GameManager.GetTimeLimit() > 0)
        {
            yield return new WaitForSeconds(1.0f);
            if (b.GetComponent<testtt>().SoundTimer < 40)
            {
                GameManager.SetTimeLimit(GameManager.GetTimeLimit() - 1);
            }
        }
    }
}
