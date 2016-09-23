using UnityEngine;
using System.Collections;

public class animGameLogic : MonoBehaviour {

    public Animator loadingScreen;
    public Animator gameStart;
    public Animator gameEnd;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(waitForAnimation(loadingScreen, gameStart, "finishAnimation"));
    }

    IEnumerator waitForAnimation(Animator source, Animator target, string targetBool)
    {
        float time = source.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(time);
        target.SetBool(targetBool, true);
    }
}
