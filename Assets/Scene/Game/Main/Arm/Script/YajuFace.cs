using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YajuFace : MonoBehaviour {
    public GameObject HitEffect;
    GameObject sen;
    Vector3 pos;
    // Use this for initialization
    void Start () {
        sen = GameObject.Find("Men's");
        pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (sen.GetComponent<Osiri>().yaju)
        {
            pos.y = 0.0f;
            pos.x = -0.3f;
            GameObject ef = Instantiate(HitEffect, pos, Quaternion.identity) as GameObject;
            //Destroy(ef, 0.3f);
            sen.GetComponent<Osiri>().yaju = false;
        }
    }
}
