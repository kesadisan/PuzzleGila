using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour{

    public Leap.Unity.Detector detectorLeft;
    public Leap.Unity.Detector detectorRight;

    void Update()
    {
        /*
        if(StaticVariables.lastChosenObject != null)
        {
            if(StaticVariables.lastChosenObject.GetComponent<Leap.Unity.LeapRTS>() != null)
            {
                StaticVariables.lastChosenObject.GetComponent<Rigidbody>().useGravity = false;
                StaticVariables.lastChosenObject.GetComponent<Rigidbody>().isKinematic = true;
            }
            else
            {
                StaticVariables.lastChosenObject.GetComponent<Rigidbody>().useGravity = true;
                StaticVariables.lastChosenObject.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
        */
    }
    
    public void setIsMoving() {
        StaticVariables.isMovingObject = true;
    }

    public void setFinishedMovingLeft() {
        if (StaticVariables.movingHand == 1) {
            StaticVariables.isMovingObject = false;

            //StaticVariables.chosenObject.GetComponent<Leap.Unity.LeapRTS>().PinchDetectorA = (Leap.Unity.PinchDetector)detectorLeft;
            //StaticVariables.chosenObject.GetComponent<Leap.Unity.LeapRTS>().PinchDetectorB = (Leap.Unity.PinchDetector)detectorRight;
            StaticVariables.chosenObject = null;

            StaticVariables.leftObject = null;

            StaticVariables.lastChosenObject.GetComponent<Rigidbody>().useGravity = true;
            StaticVariables.lastChosenObject.GetComponent<Rigidbody>().isKinematic = false;
        }

        StaticVariables.lastChosenObject.GetComponent<Rigidbody>().useGravity = true;
        StaticVariables.lastChosenObject.GetComponent<Rigidbody>().isKinematic = false;

    }
    public void setFinishedMovingRight() {
        if (StaticVariables.movingHand == 2) {
            StaticVariables.isMovingObject = false;
               
            //StaticVariables.chosenObject.GetComponent<Leap.Unity.LeapRTS>().PinchDetectorA = (Leap.Unity.PinchDetector)detectorLeft;
            //StaticVariables.chosenObject.GetComponent<Leap.Unity.LeapRTS>().PinchDetectorB = (Leap.Unity.PinchDetector)detectorRight;
            StaticVariables.chosenObject = null;
            
            StaticVariables.rightObject = null;

            StaticVariables.lastChosenObject.GetComponent<Rigidbody>().useGravity = true;
            StaticVariables.lastChosenObject.GetComponent<Rigidbody>().isKinematic = false;
        }
        StaticVariables.lastChosenObject.GetComponent<Rigidbody>().useGravity = true;
        StaticVariables.lastChosenObject.GetComponent<Rigidbody>().isKinematic = false;
    }

    public void pinchLeft() {
        if (StaticVariables.isMovingObject == false && StaticVariables.chosenObject == null) {
            if (StaticVariables.leftObject != null) {
                StaticVariables.chosenObject = StaticVariables.leftObject;

                StaticVariables.lastChosenObject = StaticVariables.chosenObject;
            }

            if (StaticVariables.chosenObject != null) {
                setIsMoving();
                //detectorRight.enabled = false;
                StaticVariables.chosenObject.GetComponent<Leap.Unity.LeapRTS>().PinchDetectorB = null;
                StaticVariables.movingHand = 1;

                StaticVariables.lastChosenObject = StaticVariables.chosenObject;

                StaticVariables.lastChosenObject.GetComponent<Rigidbody>().useGravity = false;
                StaticVariables.lastChosenObject.GetComponent<Rigidbody>().isKinematic = true;
            }

            StaticVariables.lastChosenObject.GetComponent<Rigidbody>().useGravity = false;
            StaticVariables.lastChosenObject.GetComponent<Rigidbody>().isKinematic = true;  
        }
    }

    public void pinchRight() {
        if (StaticVariables.isMovingObject == false && StaticVariables.chosenObject == null) {   

            if (StaticVariables.rightObject != null) {
                StaticVariables.chosenObject = StaticVariables.rightObject;

                StaticVariables.lastChosenObject = StaticVariables.chosenObject;

                StaticVariables.lastChosenObject.GetComponent<Rigidbody>().useGravity = false;
                StaticVariables.lastChosenObject.GetComponent<Rigidbody>().isKinematic = true;
                
            }

            if (StaticVariables.chosenObject != null) {
                setIsMoving();
                //detectorLeft.enabled = false;
                StaticVariables.chosenObject.GetComponent<Leap.Unity.LeapRTS>().PinchDetectorA = null;
                StaticVariables.movingHand = 2;

                StaticVariables.lastChosenObject = StaticVariables.chosenObject;

                StaticVariables.lastChosenObject.GetComponent<Rigidbody>().useGravity = false;
                StaticVariables.lastChosenObject.GetComponent<Rigidbody>().isKinematic = true;
            }

            StaticVariables.lastChosenObject.GetComponent<Rigidbody>().useGravity = false;
            StaticVariables.lastChosenObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
