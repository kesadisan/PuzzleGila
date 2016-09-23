using UnityEngine;
using System.Collections;

public class ObjectBehavior : MonoBehaviour {

    public int ID = 0;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Rotate(new Vector3(-1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Rotate(new Vector3(1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(new Vector3(0, 0, 1f));
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(new Vector3(0, 0, -1f));
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(new Vector3(0, 1f, 0));
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(new Vector3(0, -1f, 0));
        }

    }
}
