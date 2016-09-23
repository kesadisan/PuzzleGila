using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ShapeMatcher : MonoBehaviour {

    public int shapeID;
    public CheckWinCondition _CheckWin;

    public List<XYZSerializable> listTargetRotation = new List<XYZSerializable>();

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col) {
        if (col.tag == "target") {
            if(col.GetComponent<ObjectBehavior>().ID == shapeID) {
                checkRotation(col.gameObject);
                Debug.Log("test");
            }
        }
    }

    void checkRotation(GameObject target) {

        float targetX = target.transform.eulerAngles.x;

        float targetY = target.transform.eulerAngles.y;

        float targetZ = target.transform.eulerAngles.z;

        bool flag = false;

        foreach (XYZSerializable xyz in listTargetRotation) {

            /*
            float maxX = this.transform.eulerAngles.x + 10f;
            float minX = this.transform.eulerAngles.x - 10f;

            float maxY = this.transform.eulerAngles.y + 10f;
            float minY = this.transform.eulerAngles.y - 10f;

            float maxZ = this.transform.eulerAngles.z + 10f;
            float minZ = this.transform.eulerAngles.z - 10f;
            */

            float maxX = xyz.x + 10f;
            float minX = xyz.x - 10f;

            float maxY = xyz.y + 10f;
            float minY = xyz.y - 10f;

            float maxZ = xyz.z + 10f;
            float minZ = xyz.z - 10f;

            if (targetX + 10.0f > 360) maxX += 360;
            if (targetX - 10.0f < 0) minX -= 360;

            if (targetY + 10.0f > 360) maxY += 360;
            if (targetY - 10.0f < 0) minY -= 360;

            if (targetZ + 10.0f > 360) maxZ += 360;
            if (targetZ - 10.0f < 0) minZ -= 360;

            if (targetX < maxX && targetX > minX &&
                targetY < maxY && targetY > minY &&
                targetZ < maxZ && targetZ > minZ) {
                flag = true;
            }
        }
        if (flag) {

            Debug.Log("IniCheck");
            _CheckWin.addScore();
            target.transform.parent.GetComponent<BoxCollider>().enabled = false;
            target.GetComponent<SphereCollider>().enabled = false;
            this.transform.parent.gameObject.SetActive(false);
            Destroy(this.transform.parent.gameObject);
        }

    }
}
