using UnityEngine;
using System.Collections;

public class MenuTrigger : MonoBehaviour {

    public Animator MenuScreen;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToMenu1()
    {
        MenuScreen.SetBool("ToMenu-1", true);
        MenuScreen.SetBool("ToMenu-2", false);
    }

    public void ToMenu2()
    {
        MenuScreen.SetBool("ToMenu-2", true);
        MenuScreen.SetBool("ToMenu-1", false);
        MenuScreen.SetBool("ToTheme1", false);
        MenuScreen.SetBool("ToTheme2", false);
        MenuScreen.SetBool("ToTheme3", false);
        MenuScreen.SetBool("ToTheme4", false);
    }

    public void ToTheme1()
    {
        MenuScreen.SetBool("ToTheme1", true);
        MenuScreen.SetBool("ToMenu-2", false);
    }
    public void ToTheme2()
    {
        MenuScreen.SetBool("ToTheme2", true);
        MenuScreen.SetBool("ToMenu-2", false);
    }
    public void ToTheme3()
    {
        MenuScreen.SetBool("ToTheme3", true);
        MenuScreen.SetBool("ToMenu-2", false);
    }
    public void ToTheme4()
    {
        MenuScreen.SetBool("ToTheme4", true);
        MenuScreen.SetBool("ToMenu-2", false);
    }
}
