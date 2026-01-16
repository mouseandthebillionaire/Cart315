using System;
using System.Threading;
using UnityEngine;

public class Collector : MonoBehaviour {
    public float xLoc, yLoc = 0;
    public float speed = 0.1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        xLoc = 0;
        yLoc = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z)) {
            Debug.Log("Left");
            // update the variable
            xLoc -= speed;

        }
        if (Input.GetKey(KeyCode.X)) {
            Debug.Log("Right");
            // update the variable
            xLoc += speed;
        }

        // Update the position
        this.transform.position = new Vector3(xLoc, yLoc, 0);

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Circle") {
            Destroy(other.gameObject);
        }
    }
}
