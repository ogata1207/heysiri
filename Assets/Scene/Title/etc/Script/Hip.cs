using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hip : MonoBehaviour {
    public Animator anim;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // BombObj.GetComponent<ParticleController>().Play();

        //else
        //{
        //    BombObj.GetComponent<ParticleController>().Stop();
        //}
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "RightArm")
        {
            anim.SetTrigger("Hip");
        }
        else anim.ResetTrigger("Hip");
    }

}
