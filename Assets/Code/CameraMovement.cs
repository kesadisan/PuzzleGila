using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    
    public GameObject targetObject;

    public GameObject cameraLookAt;

    public float zLowerLimit = -1.0f;
    public float zHigherLimit = 0.0f;

    public float orbitSpeed = 20.0f;

	// Use this for initialization
	void Start () {
        cameraLookAtPosition();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            zoomIn();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            zoomOut();
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            rotateLeft();
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rotateRight();
        }
    }

    void zoomIn()
    {
        if (targetObject.transform.localPosition.z < zHigherLimit)
        {
            targetObject.transform.Translate(new Vector3(0.0f, 0.0f, 0.1f));

            //targetObject.transform.position = targetCamera.transform.position;
        }
    }

    void zoomOut()
    {
        if (targetObject.transform.localPosition.z > zLowerLimit)
        {
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

        Vector3 targetPos = new Vector3(cameraLookAt.transform.position.x,
                                        cameraLookAt.transform.position.y,
                                        cameraLookAt.transform.position.z);

        targetObject.transform.RotateAround(targetPos, Vector3.up, orbitSpeed * Time.deltaTime);
    }

    void rotateRight()
    {

        Vector3 targetPos = new Vector3(cameraLookAt.transform.position.x,
                                        cameraLookAt.transform.position.y,
                                        cameraLookAt.transform.position.z);

        targetObject.transform.RotateAround(targetPos, Vector3.up, -orbitSpeed * Time.deltaTime);
    }
}
