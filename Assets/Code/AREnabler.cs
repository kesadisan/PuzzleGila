using UnityEngine;
using System.Collections;

public class AREnabler : MonoBehaviour {

    public GameObject A;
    bool arEnabled = false;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if(arEnabled == false)
            {
                A.SetActive(true);
                arEnabled = true;
            }
            else
            {
                A.SetActive(false);
                arEnabled = false;
            }
            
        }
	}
}
