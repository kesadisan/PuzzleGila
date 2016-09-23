using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]


public class videoPlayer : MonoBehaviour {

    public MovieTexture movie;
    private AudioSource movieAudio;
    private GameObject playerVideo;
    public Animator animTitle;

	// Use this for initialization
	void Start () {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        movieAudio = GetComponent<AudioSource>();
        movieAudio.clip = movie.audioClip;
        playerVideo = this.gameObject;
        //animTitle = GameObject.Find("TitleScreenBox").GetComponent<Animator>();
        
        movie.Play();
        movieAudio.Play();

        StartCoroutine(FindEnd());
    }
	
	// Update is called once per frame
	void Update () {

	}

    IEnumerator FindEnd()
    {
        while (movie.isPlaying)
        {
            yield return null;
        }
        Destroy(playerVideo);
        animTitle.SetBool("Finished", true);
        
        yield break;
    }


}
