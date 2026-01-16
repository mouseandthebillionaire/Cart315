using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickLayerManager : MonoBehaviour {
    public GameObject brick;

    public int rows, columns;

    public float brickSpacing_h;
    public float brickSpacing_v;
    
    
    // Start is called before the first frame update
    void Start() {
        for (int i = 0; i < columns; i++) {
            for (int j = 0; j < rows; j++) {
                float xPos = -columns + (i * brickSpacing_h);
                float yPos = rows - (j * brickSpacing_v);
                Instantiate(brick, new Vector3(xPos, yPos, 0), transform.rotation);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
