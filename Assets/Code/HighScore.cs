using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {

    public Text Level1;
    public Text Level2;
    public Text Level3;
    public Text Level4;
    public Text Level5;
    public Text Level6;
    public Text Level7;
    public Text Level8;
    public Text Level9;
    public Text Level10;
    public Text Level11;
    public Text Level12;
    public Text Level13;
    public Text Level14;
    public Text Level15;
    public Text Level16;

    private int[] scoreArray;

	// Use this for initialization
	void Start () {
        fillArray();
        Level1.text = getScoreByStageNum(0).ToString();
        Level2.text = getScoreByStageNum(1).ToString();
        Level3.text = getScoreByStageNum(2).ToString();
        Level4.text = getScoreByStageNum(3).ToString();
        Level5.text = getScoreByStageNum(4).ToString();
        Level6.text = getScoreByStageNum(5).ToString();
        Level7.text = getScoreByStageNum(6).ToString();
        Level8.text = getScoreByStageNum(7).ToString();
        Level9.text = getScoreByStageNum(8).ToString();
        Level10.text = getScoreByStageNum(9).ToString();
        Level11.text = getScoreByStageNum(10).ToString();
        Level12.text = getScoreByStageNum(11).ToString();
        Level13.text = getScoreByStageNum(12).ToString();
        Level14.text = getScoreByStageNum(13).ToString();
        Level15.text = getScoreByStageNum(14).ToString();
        Level16.text = getScoreByStageNum(15).ToString();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public int getScoreByStageNum(int num)
    {
        int score = scoreArray[num];
        return score;
    }
    public void fillArray()
    {
        scoreArray = PlayerPrefsX.GetIntArray("highScore", 9999, 16);
    }
}
