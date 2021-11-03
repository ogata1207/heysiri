using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MauseClick : MonoBehaviour {
    SpriteRenderer sp;
    GameObject cp;
	// Use this for initialization
	void Start () {
        sp = GetComponent<SpriteRenderer>();
        cp = GameObject.Find("ComboPanel");
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)/*&& cp.GetComponent<ComboManager>().RightActive*/)
        {
            sp.sortingOrder = 1;
        }

        if (Input.GetMouseButtonUp(0))
        {
            sp.sortingOrder = -1;
        }
    }
}
