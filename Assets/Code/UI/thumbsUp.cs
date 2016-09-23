using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class thumbsUp : MonoBehaviour {

    private int stateTutorial;
    public Animator TitleScreen;
    public Animator TutorialScreen;

	// Use this for initialization
	void Start () {
        stateTutorial = 0;
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void callNextTutorial()
    {
        checkStateTutorial();
        stateTutorial++;
    }

    void checkStateTutorial()
    {
        if(stateTutorial == 0)
        {
            TitleScreen.SetBool("ToTutorial", true);
            StartCoroutine(waitForAnimation(TitleScreen,TutorialScreen,"Page1"));
        }
        else if (stateTutorial == 1)
        {
            TutorialScreen.SetBool("Page2", true);
        }
        else if (stateTutorial == 2)
        {
            TutorialScreen.SetBool("Page3", true);
        }
        else if (stateTutorial == 3)
        {
            TutorialScreen.SetBool("EndTut", true);
            TitleScreen.SetBool("MusicOff", true);
            StartCoroutine(waitForAnimationLoad(TitleScreen, "Level1"));
        }
    }

    IEnumerator waitForAnimation(Animator source,Animator target,string targetBool)
    {
        float time = source.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(time);
        target.SetBool(targetBool, true);
    }

    IEnumerator waitForAnimationLoad(Animator anim,string targetScene)
    {
        float time = anim.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(targetScene);
    }
}
