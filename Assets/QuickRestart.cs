using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class QuickRestart : MonoBehaviour {

    public Animator LoadLevelAnim;
    public Animator MusicPlayer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            LoadLevelAnim.SetBool("startLoadingNext", true);
            MusicPlayer.SetBool("isReloadLevel", true);
            StartCoroutine(waitForAnimation(LoadLevelAnim));
        }
    }

    IEnumerator waitForAnimation(Animator source)
    {
        //float time = source.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
