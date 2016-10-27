using UnityEngine;
using System.Collections;

public class MenuLoading : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void playLoading()
    {
        GameObject.Find("Loading").GetComponent<Animator>().Play("startLoadingInGame", -1, 0.0f);
    }
}
