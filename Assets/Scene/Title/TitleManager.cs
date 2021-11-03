using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor;
public class TitleManager : MonoBehaviour {

    GameObject Hip;
    // Use this for initialization
    void Start()
    {
        GameManager.Init();
        Hip = GameObject.Find("TitleHip");
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A)) SceneManager.LoadScene("Wait");

        if (Hip.GetComponent<TitleHipHop>().ChangeTimer > 50)
        {

            SceneManager.LoadScene("Main");
            Hip.GetComponent<TitleHipHop>().ChangeTimer = 0;
            Hip.GetComponent<TitleHipHop>().TimerF = false;
        }

    }
}
