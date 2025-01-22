using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    public GameObject bullet;
    public KeyCode shoot;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shoot)) {
            Instantiate(bullet, this.transform.position, Quaternion.identity);
        }
    }
}
