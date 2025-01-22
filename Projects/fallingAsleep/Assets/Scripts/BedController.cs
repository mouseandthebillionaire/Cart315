using UnityEngine;

public class BedController : MonoBehaviour {

    public float xLoc = 0;
    public float bedSpeed = .1f;

    public float score;
    
    // Start is called before the first frame update
    void Start() {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) && xLoc > -9f) {
            xLoc -= bedSpeed;
            
        }
        if (Input.GetKey(KeyCode.X) && xLoc < 9f) {
            xLoc += bedSpeed;
        }

        this.transform.position = new Vector3(
            xLoc, 
            transform.position.y, 
            transform.position.z
            );
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "Sleepy") score += 1;
        else score -= 1;
        
        Destroy(other.gameObject);

    }
}
