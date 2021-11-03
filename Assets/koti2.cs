using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koti2 : MonoBehaviour {

    Vector3 pos;

    // Use this for initialization
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    pos.y = 2.0f;
        //}

        if (GameManager.GetLorR() == 1)
        {
            pos.y = 3.5f;
        }
        else
        {
            pos.y = 6.0f;
        }


        transform.position = pos;
    }
}
