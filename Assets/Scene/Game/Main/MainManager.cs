using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour {
    public Slider slider;
    public GameObject[] obj;
    public bool HitStop;
    private int ChangeTimer;


    //public AudioSource AudioSource;

    // Use this for initialization
    void Start() {

        HitStop = false;
        ChangeTimer = 0;

        //StartCoroutine(HealthUpdate());
        int number = 0;
        if (GameManager.GetClearNum() % 5 == 0) number = 1;
        if (GameManager.GetClearNum() % 3 == 0) number = 2;

        obj[number].SetActive(true);
        slider.maxValue = GameManager.GetSliderHealth();
    }

    // Update is called once per frame
    void Update() {
        if (Time.timeScale >= 4.9f)
        {
            Time.timeScale = 4.9f;
        }
        //if (GameManager.GetCombo() > 10)
        //{
        //    Time.timeScale = 1.2f;
        //}
        //if (GameManager.GetCombo() > 20)
        //{
        //    Time.timeScale = 1.5f;
        //}
        //if (GameManager.GetCombo() > 30)
        //{
        //    Time.timeScale = 1.8f;
        //}

        if (Input.GetKeyDown(KeyCode.I)) GameManager.Init();
        //if (Input.GetKeyDown(KeyCode.A)) SceneManager.LoadScene("Wait");
        if (Input.GetKeyDown(KeyCode.Q)) Application.Quit();

        if (slider.value == slider.maxValue)
        {
            HitStop = true;
            //float speed = this.AudioSource.pitch;
            //this.AudioSource.pitch = speed += 1.3f;
            GameManager.SetSliderHealth(slider.maxValue * 1.1f);
            //staticSceneManager.GameClear();
        }
        if (HitStop)
        {
            ChangeTimer++;
            if (ChangeTimer >= 120)
            {
                staticSceneManager.GameClear();
                ChangeTimer = 0;
                HitStop = false;
            }
        }
        if (GameManager.GetTimeLimit() == 0/*||Input.GetKeyDown(KeyCode.S)*/) SceneManager.LoadScene("Result");
        
    }

    IEnumerator HealthUpdate()
    {
        while (slider.value != slider.maxValue)
        {
            slider.value -= 0.1f;
            yield return null;
            //yield return new WaitForSeconds(0.1f);
        }
    }
}