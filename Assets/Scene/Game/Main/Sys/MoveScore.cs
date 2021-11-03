using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveScore : MonoBehaviour {

    public Text text;
    private Color c;
	// Use this for initialization
	void Start () {
        c = text.color;
        StartCoroutine(Move());
	}

    IEnumerator Move()
    {
        while(true)
        {
            c.a -= 0.025f;
            text.color = new Color( c.r, c.g, c.b, c.a);
            text.rectTransform.position += new Vector3(0, 2, 0);
            yield return null;
        }
        
    }
}
