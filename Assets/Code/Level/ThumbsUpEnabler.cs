using UnityEngine;
using System.Collections;

public class ThumbsUpEnabler : MonoBehaviour {

    public Leap.Unity.DetectorLogicGate detectorLogicGate;
    public Leap.Unity.ExtendedFingerDetector extendedFingerDetector;
    public Leap.Unity.FingerDirectionDetector fingerDirection1;
    public Leap.Unity.FingerDirectionDetector fingerDirection2;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void enableScript()
    {
        detectorLogicGate.enabled = true;
        extendedFingerDetector.enabled = true;
        fingerDirection1.enabled = true;
        fingerDirection2.enabled = true;
    }
}
