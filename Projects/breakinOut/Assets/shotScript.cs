using System;
using UnityEngine;

public class shotScript : MonoBehaviour {
    private Renderer r;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        r = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update() {
        if(!r.isVisible) Destroy(this.gameObject);
    }
    
    

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy") {
            // score a point
            
            // destroy the enemy
            Destroy(other.gameObject);
            
            // destroy yourself
            Destroy(this.gameObject);
        }
    }
}
