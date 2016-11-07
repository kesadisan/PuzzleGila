using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class IntroSystemController : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
        StartCoroutine(WaitThenDoThings(9));
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator WaitThenDoThings(float time)
    {
        yield return new WaitForSeconds(time);

        // Now do some stuff...

        SceneManager.LoadScene("MainMenuLeapUI");
    }
}
