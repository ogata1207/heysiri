using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WaitManager : MonoBehaviour {
    // public GameObject gObj;
    // public Text text;
    // Use this for initialization
    int timer;
	void Start ()
    {
        timer = 0;
      // text.text = GameManager.GetClearNum() + "かいめくりあ";
        //Debug.Log("クリア回数 : " + GameManager.GetClearNum());
	}
	
	// Update is called once per frame
	void Update () {
        timer++;
        if (timer>30)
        {
            SceneManager.LoadScene("Main");
            timer = 0;
        }
       // if (Input.GetKeyDown(KeyCode.S)) SceneManager.LoadScene("Result");
    }
}
