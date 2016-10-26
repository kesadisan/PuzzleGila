using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScore : MonoBehaviour {

    public Text test;
    private int[] scoreArray;

	// Use this for initialization
	void Start () {
        fillArray();
        test.text = getScoreByStageNum(0).ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void insertRandom()
    {
        int[] scoreArray = PlayerPrefsX.GetIntArray("highScore", 9999, 16);
        scoreArray[0] = 100;
        PlayerPrefsX.SetIntArray("highScore", scoreArray);
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
