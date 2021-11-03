using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.H)) StartCoroutine(Zoom());
	}

    IEnumerator Zoom()
    {
        GameObject camera = GameObject.FindWithTag("MainCamera");
        float size = camera.GetComponent<Camera>().orthographicSize;
        while(size > 1.6f)
        {
            size -= 0.1f;
            camera.GetComponent<Camera>().orthographicSize = size;
            yield return null;
        }
        yield return null;
        while(size <= 5.0f)
        {
            size += 0.01f;
            camera.GetComponent<Camera>().orthographicSize = size;
        }
        yield return null;

        camera.GetComponent<Camera>().orthographicSize = 5.0f;
        yield return null;
    }


}
