using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public int timeElapsed;
    public Text timeUIText;

    public Coroutine corTime;
    public bool isPlaying;
    public int stageNum;

    // Use this for initialization
    void Start () {
        timeElapsed = 0;
        timeUIText = this.GetComponent<Text>();
        corTime = StartCoroutine(timer());
        isPlaying = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator timer()
    {
        while (isPlaying == true) {
            yield return new WaitForSeconds(1.0f);
            timeElapsed++;
            timeUIText.text = timeElapsed.ToString();
        }
    }

    public void stopTimer()
    {
        isPlaying = false;
        StopCoroutine(corTime);
    }

    public void saveTime()
    {
        int[] scoreArray = PlayerPrefsX.GetIntArray("highScore",9999,16);

        if (scoreArray[stageNum] > timeElapsed)
        {
            scoreArray[stageNum] = timeElapsed;
        }

        PlayerPrefsX.SetIntArray("highScore",scoreArray);
    }
}
