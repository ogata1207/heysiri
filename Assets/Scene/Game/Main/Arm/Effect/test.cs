using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    GameObject a;
    GameObject b;
    public GameObject HitEffect;
    public GameObject MissEffect;
    public GameObject DeadEffect;
    public GameObject TimeEffect;

    // Use this for initialization
    void Start () {
        a = GameObject.Find("Left");
        b = GameObject.Find("Right");
    }

    // Update is called once per frame
    void Update () {
        if (a.GetComponent<lefttestt>().f)
        {
            GameObject ef = Instantiate(HitEffect, transform.position, Quaternion.identity) as GameObject;
            Destroy(ef, 0.3f);
            a.GetComponent<lefttestt>().f = false;
        }

        else if (b.GetComponent<testtt>().f)
        {
            GameObject ef = Instantiate(HitEffect, transform.position, Quaternion.identity) as GameObject;
            Destroy(ef, 0.3f);
            b.GetComponent<testtt>().f = false;
        }

        // ミスえふぇ
        if (a.GetComponent<lefttestt>().f2)
        {
            GameObject ef = Instantiate(MissEffect, transform.position, Quaternion.identity) as GameObject;
            Destroy(ef, 0.6f);
            a.GetComponent<lefttestt>().f2 = false;
        }

        else if (b.GetComponent<testtt>().f2)
        {
            GameObject ef = Instantiate(MissEffect, transform.position, Quaternion.identity) as GameObject;
            Destroy(ef, 0.6f);
            b.GetComponent<testtt>().f2 = false;
        }

        if (b.GetComponent<testtt>().SoundTimer>40)
        {
            GameObject ef = Instantiate(DeadEffect, transform.position, Quaternion.identity) as GameObject;
            Destroy(ef, 1.0f);

        }

        if (b.GetComponent<testtt>().SoundTimer > 80)
        {
            //5.5 2.51
            Vector3 pos;
            pos = transform.position;
            pos.x = 5.2f;
            pos.y = 2.51f;
            GameObject ef = Instantiate(TimeEffect, transform.position, Quaternion.identity) as GameObject;
            Destroy(ef, 1.0f);

        }

    }
}
