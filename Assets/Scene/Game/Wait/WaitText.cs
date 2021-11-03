using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitText : MonoBehaviour {

    public Text text;
	// Use this for initialization


	void Start () {
        text.text = "CLEAR  " + GameManager.GetClearNum();	
	}
	
	// Update is called once per frame
	
}
