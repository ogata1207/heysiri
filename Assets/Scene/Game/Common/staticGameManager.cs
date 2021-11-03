static public class GameManager
{
    static private int TimeLimit = 60;       //制限時間
    static private int Score;           //スコア
    static private int Combo;           //コンボ

    static private int ClearNum = 1;        //クリアした数
    static private int LorR;            //Left:0 Right:1
    static private int ChangeTime;      //左右が入れ替わるまでの時間
    static private float SliderHealth = 5.0f;
    static public void Init()
    {
        //忘れるな
        TimeLimit = 0;
        Score = 0;
        Combo = 0;
        ClearNum = 1;
        LorR = 0;
        TimeLimit = 60;
        SliderHealth = 100;
        //ChangeTime = 10;
    }

    //*********************************************************************************************************
    //
    //  
    //
    //*********************************************************************************************************
    static public int GetTimeLimit()
    {
        return TimeLimit;
    }
    static public int GetScore()
    {
        return Score;
    }
    static public int GetCombo()
    {
        return Combo;
    }

    static public int GetClearNum()
    {
        return ClearNum;
    }

    static public int GetLorR()
    {
        return LorR;
    }


    static public int GetChangeTime()
    {
        return ChangeTime;
    }

    static public float GetSliderHealth()
    {
        return SliderHealth;
    }

    //*********************************************************************************************************
    //
    //  
    //
    //*********************************************************************************************************

    static public void SetTimeLimit(int time)
    {
        TimeLimit = time;
    }
    static public void SetScore(int score)
    {
        Score = score;
    }
    static public void SetCombo(int combo)
    {
        Combo = combo;
    }

    static public void SetClearNum(int num)
    {
        ClearNum = num;
    }
    static public void SetLorR(int hoge)
    {
        LorR = hoge;
    }

    static public void SetChangeTime(int time)
    {
        ChangeTime = time;
    }

    static public void SetSliderHealth(float hp)
    {
        SliderHealth = hp;
    }
    //*********************************************************************************************************
    //
    //  
    //
    //*********************************************************************************************************

    static public void AddTimeLimit(int add)
    {
        TimeLimit += add;
    }
    static public void AddScore(int add)
    {
        Score += add;
    }

    static public void AddCombo(int add)
    {
        Combo += add;
    }

    static public void AddClearNum(int add)
    {
        ClearNum += add;
    }

}
