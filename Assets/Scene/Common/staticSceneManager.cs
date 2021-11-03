using UnityEngine.SceneManagement;
using UnityEngine;
static public class staticSceneManager
{
    //使わん
    static public void ChangeScene(string SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
    }

    //ゲームクリア(ゲームメインから待機シーンに移動)
    //クリア回数を追加してから待機シーンに移動
    static public void GameClear()
    {
        float timeScale = Time.timeScale;
        Time.timeScale = timeScale + 0.3f;        

        GameManager.SetLorR(0);
        GameManager.SetTimeLimit(GameManager.GetTimeLimit() + 12);

        //if (GameManager.GetClearNum() <= 18)
        //{
        //    GameManager.SetTimeLimit(GameManager.GetTimeLimit() + 12);
        //}
        //if (GameManager.GetClearNum() >=20)
        //{
        //    GameManager.SetTimeLimit(GameManager.GetTimeLimit() + 30);
        //}
        GameManager.AddClearNum(1);
       // GameManager.SetCombo(0);
        ChangeScene("Wait");
    }
}
