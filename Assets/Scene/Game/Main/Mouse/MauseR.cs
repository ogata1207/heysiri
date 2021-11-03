using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MauseR : MonoBehaviour {

    SpriteRenderer sp;
    GameObject cp;
    // Use this for initialization
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        cp = GameObject.Find("ComboPanel");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1)/*&& cp.GetComponent<ComboManager>().RightActive*/)
        {
            sp.sortingOrder = 1;
        }

        if (Input.GetMouseButtonUp(1))
        {
            sp.sortingOrder = -1;
        }
    }
}
