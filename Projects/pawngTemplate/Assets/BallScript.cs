using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallScript : MonoBehaviour {
    // THIS BALL IS ALL POWERFUL IS CONTROLS TIME, SPACE, AND SCORING
    
    public float ballSpeed = 2;
    private int[] directionOptions = {-1, 1};
    private int hDir, vDir;
    
    public int score1, score2;
    public AudioSource blip;
    
    private Rigidbody2D rb;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
        StartCoroutine(Launch());
    }

    private void OnCollisionEnter2D(Collision2D wall) {

        if (wall.gameObject.name == "leftWall") {
            // give points to Player 2
            score2 += 1;
            Reset();
        }
        if (wall.gameObject.name == "rightWall") {
            // give points to Player 1
            score1 += 1;
            Reset();
        }

        if (wall.gameObject.name == "topWall" || wall.gameObject.name == "bottomWall") {
            blip.pitch = 0.75f;
            blip.Play();
            // blip.pitch = 1;
        } 
        
        if (wall.gameObject.name == "paddleLeft" || wall.gameObject.name == "paddleRight") {
            blip.pitch = 1f;
            blip.Play();
        } 
        
        
    }


    private IEnumerator Launch() {
        // choose Random X dir
        hDir = directionOptions[Random.Range(0, directionOptions.Length)];
        // choose Random Y dir
        vDir = directionOptions[Random.Range(0, directionOptions.Length)];
        Random.Range(0, directionOptions.Length);
        
        // wait for X seconds
        yield return new WaitForSeconds(1);
        
        // Apply Force
        // Horizontal
        rb.AddForce(transform.right * ballSpeed * hDir);
        // Vertical 
        rb.AddForce(transform.up * ballSpeed * vDir);
    }

    void Reset() {
        rb.linearVelocity = Vector2.zero;
        this.transform.localPosition = new Vector3(0, 0, 0);
        // Launch
        StartCoroutine(Launch());
    }
}
