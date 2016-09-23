using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class GameMusicController : MonoBehaviour {
    
    public AudioSource mainBGM;
    public AudioSource finishBGM;
    public Animator musicPlayer;
    
	// Use this for initialization
	void Start () {
        
	}
	
	public void winBGMStart()
    {
        musicPlayer.SetBool("isWinning", true);
        finishBGM.Play();
    }

    public void turnDownMusic()
    {
        musicPlayer.SetBool("isChangeLevel", true);
    }
}
