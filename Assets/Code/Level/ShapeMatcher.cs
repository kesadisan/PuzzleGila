using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ShapeMatcher : MonoBehaviour {

    public int shapeID;
    public CheckWinCondition _CheckWin;
    private float offset = 20.0f;

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
                //For level making
                Debug.Log("Hit!");
                Debug.Log("X:");
                Debug.Log(col.gameObject.transform.eulerAngles.x);
                Debug.Log("Y:");
                Debug.Log(col.gameObject.transform.eulerAngles.y);
                Debug.Log("Z:");
                Debug.Log(col.gameObject.transform.eulerAngles.z);
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

            float maxX = xyz.x + offset;
            float minX = xyz.x - offset;

            float maxY = xyz.y + offset;
            float minY = xyz.y - offset;

            float maxZ = xyz.z + offset;
            float minZ = xyz.z - offset;

            if (targetX + offset > 360) maxX += 360;
            if (targetX - offset < 0) minX -= 360;

            if (targetY + offset > 360) maxY += 360;
            if (targetY - offset < 0) minY -= 360;

            if (targetZ + offset > 360) maxZ += 360;
            if (targetZ - offset < 0) minZ -= 360;

            if (targetX < maxX && targetX > minX &&
                targetY < maxY && targetY > minY &&
                targetZ < maxZ && targetZ > minZ) {
                flag = true;
            }
        }
        if (flag) {

            Debug.Log("Gotcha!");
            _CheckWin.addScore();
            
            target.transform.parent.GetComponent<BoxCollider>().enabled = false;
            target.transform.parent.GetComponent<MovementBehavior>().setUnmovable();
            target.GetComponent<SphereCollider>().enabled = false;

            GameObject.Find("MusicPlayer").GetComponent<GameMusicController>().playSFX();
            GameObject.Find("GameMaster").GetComponent<GameMaster>().playFlash();

            this.transform.parent.gameObject.SetActive(false);
            Destroy(this.transform.parent.gameObject);
        }

    }
}
