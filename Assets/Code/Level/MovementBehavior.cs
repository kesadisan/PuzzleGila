using UnityEngine;
using System.Collections;

public class MovementBehavior : MonoBehaviour {

    bool isTouchingLeft = false;
    bool isTouchingRight = false;

    public Leap.Unity.LeapRTS pinchScript;

    //1 = left
    //2 = right
    public int touchingHand = 0;

	// Use this for initialization
	void Start () {
	
	}

    void FixedUpdate() {
        isTouchingLeft = false;
        isTouchingRight = false;
    }

    void LateUpdate() {
        if(isTouchingLeft == true || isTouchingRight == true) {
            pinchScript.enabled = true;
        }
        else if (isTouchingLeft == false && isTouchingRight == true) {
            pinchScript.enabled = true;
            touchingHand = 2;
            pinchScript.PinchDetectorA = null;
            pinchScript.PinchDetectorB = (Leap.Unity.PinchDetector)GameObject.Find("GameMaster").GetComponent<GameMaster>().detectorRight;
        }
        else if (isTouchingLeft == true && isTouchingRight == false) {
            pinchScript.enabled = true;
            touchingHand = 1;
            pinchScript.PinchDetectorA = (Leap.Unity.PinchDetector)GameObject.Find("GameMaster").GetComponent<GameMaster>().detectorLeft;
            pinchScript.PinchDetectorB = null;
        }
        else if(isTouchingLeft == false && isTouchingRight == false) { 
            pinchScript.enabled = false;
            touchingHand = 0;
            pinchScript.PinchDetectorA = (Leap.Unity.PinchDetector)GameObject.Find("GameMaster").GetComponent<GameMaster>().detectorLeft;
            pinchScript.PinchDetectorB = (Leap.Unity.PinchDetector)GameObject.Find("GameMaster").GetComponent<GameMaster>().detectorRight;
        }
    }

        /*
        // Update is called once per frame
        void Update () {
            if (Input.GetKey(KeyCode.W)) {
                transform.Translate(new Vector3(0, 0, 0.1f));
            }
            if (Input.GetKey(KeyCode.S)) {
                transform.Translate(new Vector3(0, 0, -0.1f));
            }
            /*
            if(target != null) {
                this.transform.position = target.transform.position;
                this.transform.eulerAngles = new Vector3(target.transform.eulerAngles.x, target.transform.eulerAngles.y, target.transform.eulerAngles.z);
            }

        }
        */
        //GameObject target = null;

    void OnTriggerStay(Collider col) {
        if (StaticVariables.isMovingObject == false || StaticVariables.chosenObject == this.gameObject) {
            
            if (col.tag == "Left") {
                if (touchingHand == 0) {
                    isTouchingLeft = true;
                    touchingHand = 1;
                    StaticVariables.leftObject = this.gameObject;
                    pinchScript.PinchDetectorB = null;
                }
                else if(touchingHand == 1) {
                    isTouchingLeft = true;
                }
            }
            if (col.tag == "Right") {
                if (touchingHand == 0) {
                    isTouchingRight = true;
                    touchingHand = 2;
                    StaticVariables.rightObject = this.gameObject;
                    pinchScript.PinchDetectorA = null;
                }
                else if (touchingHand == 2) {
                    isTouchingRight = true;
                }
            }
        }
        //Debug.Log(col.tag);

        /*
        if(col.gameObject.name == "bone1" || col.gameObject.name == "bone2" || col.gameObject.name == "bone3" || col.gameObject.name == "palm" || col.gameObject.name == "forearm") {
            target = col.gameObject;

            this.GetComponent<BoxCollider>().enabled = false;
        }
        */
    }
}
