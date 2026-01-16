using System.Collections;
using UnityEngine;

public class SleepyManager : MonoBehaviour {
    public GameObject sleepy;
    
    // Start is called before the first frame update
    void Start() {
        StartCoroutine(SleepySpawn());
    }

    private IEnumerator SleepySpawn() {
        float x = Random.Range(-8f, 8f);
        Vector3 sPos = new Vector3(x, 6, 0);
        Instantiate(sleepy, sPos, transform.rotation);

        yield return new WaitForSeconds(1.5f);
        StartCoroutine(SleepySpawn());
    }
}
