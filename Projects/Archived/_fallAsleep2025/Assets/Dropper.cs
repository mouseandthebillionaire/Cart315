using System.Collections;
using UnityEngine;

public class Dropper : MonoBehaviour {
    public GameObject circle;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        StartCoroutine(Drop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private IEnumerator Drop() {
        float chance = Random.Range(0, 100);
        if (chance < 50) {
            // Drop Something good
        }
        else {
            // drop somethign bad
        }
        
        
        // do something
        Debug.Log("Drop");
        float   rX  = Random.Range(-6f, 6f);
        Vector3 loc = new Vector3(rX, 6, 0);
        Instantiate(circle, loc, transform.rotation);
        // wait
        float next = Random.Range(0.25f, 1.5f);
        yield return new WaitForSeconds(next);
        // go again
        StartCoroutine(Drop());

    }
    
}
