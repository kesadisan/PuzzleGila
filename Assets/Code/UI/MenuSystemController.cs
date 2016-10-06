using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuSystemController : MonoBehaviour {

    public Animator Menu;
    public GameObject NextMenu;

    // Use this for initialization
    void Start () {
        StartCoroutine(WaitThenDoThings(3));
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator WaitThenDoThings(float time)
    {
        yield return new WaitForSeconds(time);

        // Now do some stuff...

        NextMenu.SetActive(true);
    }
}
