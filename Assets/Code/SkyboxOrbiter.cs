using UnityEngine;
using System.Collections;

public class SkyboxOrbiter : MonoBehaviour {

    public float ySpeed = 0.0f;
    public float x;
    float y;
    public float z;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        y += Time.deltaTime * ySpeed;

        transform.rotation = Quaternion.Euler(x, y, z);
    }
}
