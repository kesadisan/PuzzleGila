using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CheckWinCondition : MonoBehaviour {

    public int howManyShape;
    public Animator winBox;
    //public ThumbsUpEnabler thumbsUpLeft;
    //public ThumbsUpEnabler thumbsUpRight;
    public GameMusicController gameMusic;
    private int currentScore;
    public GameObject timerFunc;

    // Use this for initialization
    void Start () {
        currentScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void addScore()
    {
        currentScore++;
        checkHowManyShape();
    }

    void checkHowManyShape()
    {
        Debug.Log(currentScore);
        if (howManyShape == currentScore)
        {
            winBox.SetBool("WinTheGame", true);
            //thumbsUpLeft.enableScript();
            //thumbsUpRight.enableScript();
            gameMusic.winBGMStart();
            GameObject.Find("CameraController").GetComponent<CameraMovement>().winCameraMovement();
            GameObject.Find("Number").GetComponent<Timer>().stopTimer();
        }
    }

    IEnumerator waitForAnimationLoad(Animator anim, string targetScene)
    {
        float time = anim.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(targetScene);
    }
}
