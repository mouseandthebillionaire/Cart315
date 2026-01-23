using System.Security.Cryptography;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -8) {
            Destroy(this.gameObject);
        }
    }
}
