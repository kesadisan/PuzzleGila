using UnityEngine;
using System.Collections;

public class AREnable : MonoBehaviour {

    private MeshRenderer mr;
    private Transform thisTransform;

	// Use this for initialization
	void Start () {
        thisTransform = transform;
        mr = thisTransform.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
       mr.enabled = Input.GetButton("Calibrate");
	}
}
