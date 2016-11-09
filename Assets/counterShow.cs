using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class counterShow : MonoBehaviour {

    public Text counterText;
    public Text counterTextShadow;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void grabText(int counter, int howManyShape) {
        counterText.text = counter + "/" + howManyShape;
        counterTextShadow.text = counter + "/" + howManyShape;
    }
}
