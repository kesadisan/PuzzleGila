using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class videoLoop : MonoBehaviour {

    public MovieTexture videoTexture;

	// Use this for initialization
	void Start () {
        GetComponent<RawImage>().texture = videoTexture as MovieTexture;
        videoTexture.Play();
        videoTexture.loop = true;
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
