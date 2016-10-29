using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    
    public GameObject targetObject;

    public GameObject cameraLookAt;

    public float zLowerLimit = 10.0f;
    public float zHigherLimit = -10.0f;

    public float zCounter = 0.0f;

    public float orbitSpeed = 20.0f;
    

    // Use this for initialization
    void Start () {
        cameraLookAtPosition();
        Debug.Log(cameraLookAt.transform.localRotation);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Vertical") >= 0.5)
        {
            zoomIn();
        }
        else if (Input.GetAxis("Vertical") <= -0.5)
        {
            zoomOut();
        }
        else if (Input.GetAxis("Horizontal") <= -0.5)
        {
            rotateLeft();
        }
        else if (Input.GetAxis("Horizontal") >= 0.5)
        {
            rotateRight();
        }
    }

    void zoomIn()
    {
        if (zCounter < zLowerLimit)
        {
            zCounter += 0.1f;
            targetObject.transform.Translate(new Vector3(0.0f, 0.0f, 0.1f));

            //targetObject.transform.position = targetCamera.transform.position;
        }
    }

    void zoomOut()
    {
        if (zCounter > zHigherLimit)
        {
            zCounter -= 0.1f;
            targetObject.transform.Translate(new Vector3(0.0f, 0.0f, -0.1f));

            //targetObject.transform.position = targetCamera.transform.position;
        }
    }

    void cameraLookAtPosition()
    {
        targetObject.transform.LookAt(cameraLookAt.transform);
    }

    void rotateLeft()
    {
       //float targetObjectOriginalZ = targetObject.transform.localPosition.z;

        Vector3 targetPos = new Vector3(cameraLookAt.transform.position.x,
                                        cameraLookAt.transform.position.y,
                                        cameraLookAt.transform.position.z);

        targetObject.transform.RotateAround(targetPos, Vector3.up, orbitSpeed * Time.deltaTime);
        
    }

    void rotateRight()
    {

        //float targetObjectOriginalZ = targetObject.transform.localPosition.z;

        Vector3 targetPos = new Vector3(cameraLookAt.transform.position.x,
                                        cameraLookAt.transform.position.y,
                                        cameraLookAt.transform.position.z);

        targetObject.transform.RotateAround(targetPos, Vector3.up, -orbitSpeed * Time.deltaTime);

        
    }

    public void winCameraMovement()
    {
        /*
        Vector3 targetRotation = new Vector3(0.0f,
                                             cameraLookAt.transform.localRotation.y,
                                             cameraLookAt.transform.localRotation.z);

        targetObject.transform.localRotation = Quaternion.Euler(targetRotation);
        */
        GameObject.Find("GameMaster").GetComponent<GameMaster>().playFlash();
        targetObject.transform.rotation = Quaternion.Euler(0.0f, targetObject.transform.eulerAngles.y, 0);
    }
}
