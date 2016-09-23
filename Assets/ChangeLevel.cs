using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeLevel : MonoBehaviour {

    public Animator LoadLevelAnim;
    public Animator MusicPlayer;
    public string LevelName;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changeLevel()
    {
        LoadLevelAnim.SetBool("startLoadingNext", true);
        MusicPlayer.SetBool("isChangeLevel", true);
        StartCoroutine(waitForAnimation(LoadLevelAnim));
    }

    IEnumerator waitForAnimation(Animator source)
    {
        //float time = source.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(LevelName);
    }
}
