﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameNavigation : MonoBehaviour {

    public Animator LoadLevelAnim;
    public Animator MusicPlayer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Restart"))
        {
            restartGame();
        }

        if (Input.GetButton("Exit"))
        {
            exitGame();
        }
    }

    public void restartGame()
    {
        LoadLevelAnim.SetBool("startLoadingNext", true);
        MusicPlayer.SetBool("isReloadLevel", true);
        StartCoroutine(restartLevel(LoadLevelAnim));
    }

    public void exitGame()
    {
        LoadLevelAnim.SetBool("startLoadingNext", true);
        MusicPlayer.SetBool("isReloadLevel", true);
        StartCoroutine(exitLevel(LoadLevelAnim));
    }

    IEnumerator restartLevel(Animator source)
    {
        //float time = source.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator exitLevel(Animator source)
    {
        //float time = source.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainMenuLeapUI");
    }
}
