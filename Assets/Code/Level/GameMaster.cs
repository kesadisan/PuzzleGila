using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour{

    public Leap.Unity.Detector detectorLeft;
    public Leap.Unity.Detector detectorRight;

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
        }
    }
    public void setFinishedMovingRight() {
        if (StaticVariables.movingHand == 2) {
            StaticVariables.isMovingObject = false;
            
            //StaticVariables.chosenObject.GetComponent<Leap.Unity.LeapRTS>().PinchDetectorA = (Leap.Unity.PinchDetector)detectorLeft;
            //StaticVariables.chosenObject.GetComponent<Leap.Unity.LeapRTS>().PinchDetectorB = (Leap.Unity.PinchDetector)detectorRight;
            StaticVariables.chosenObject = null;
            
            StaticVariables.rightObject = null;
        }
    }

    public void pinchLeft() {
        if (StaticVariables.isMovingObject == false && StaticVariables.chosenObject == null) {
            if (StaticVariables.leftObject != null) {
                StaticVariables.chosenObject = StaticVariables.leftObject;
            }

            if (StaticVariables.chosenObject != null) {
                setIsMoving();
                //detectorRight.enabled = false;
                StaticVariables.chosenObject.GetComponent<Leap.Unity.LeapRTS>().PinchDetectorB = null;
                StaticVariables.movingHand = 1;
            }
        }
    }

    public void pinchRight() {
        if (StaticVariables.isMovingObject == false && StaticVariables.chosenObject == null) {

            if (StaticVariables.rightObject != null) {
                StaticVariables.chosenObject = StaticVariables.rightObject;
            }

            if (StaticVariables.chosenObject != null) {
                setIsMoving();
                //detectorLeft.enabled = false;
                StaticVariables.chosenObject.GetComponent<Leap.Unity.LeapRTS>().PinchDetectorA = null;
                StaticVariables.movingHand = 2;
            }
        }
    }
}
