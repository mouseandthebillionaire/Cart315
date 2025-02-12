using UnityEngine;

public class Shooting : MonoBehaviour {
    public GameObject shot;
    public float shotSpeed = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        Fire();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire() {
        GameObject go = Instantiate<GameObject>(shot);
        go.transform.position = transform.position;
        Rigidbody2D rb = go.GetComponent<Rigidbody2D>();
        rb.linearVelocityY = shotSpeed;
    }
}
