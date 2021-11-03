using UnityEngine;
using System.Collections;

public class ShakeCamera : MonoBehaviour
{
    public float setShakeTIme; // 持続振動時間

    private float lifeTime;
    private Vector3 savePosition;
    private float lowRangeX;
    private float maxRangeX;
    private float lowRangeY;
    private float maxRangeY;
    static public bool ShakeFlg = false;
    public bool GetShakeFlg() { return ShakeFlg; }

    void Start()
    {
        if (setShakeTIme <= 0.0f)
            setShakeTIme = 0.2f;
        lifeTime = 0.0f;
        ShakeFlg = false;
    }

    void Update()
    {
        if (lifeTime < 0.0f)
        {
            transform.position = savePosition;
            lifeTime = 0.0f;
            ShakeFlg = false;
        }

        if (lifeTime > 0.0f)
        {
            ShakeFlg = true;
            lifeTime -= Time.deltaTime;
            float x_val = Random.Range(lowRangeX, maxRangeX);
            float y_val = Random.Range(lowRangeY, maxRangeY);
            transform.position = new Vector3(x_val, y_val, transform.position.z);
        }

        //if (Input.GetKeyDown("space"))
        //{
        //    if (ShakeFlg == false) CatchShake();
        //}
    }

    public void CatchShake()
    {
        savePosition = transform.position;
        lowRangeY = savePosition.y - 0.4f;
        maxRangeY = savePosition.y + 0.4f;
        lowRangeX = savePosition.x - 0.4f;
        maxRangeX = savePosition.x + 0.4f;
        lifeTime = setShakeTIme;
    }
}