using System.Collections;
using UnityEngine;

public class BuildingDropperScript : MonoBehaviour {
    public GameObject building;

    public Sprite[] buildingSprites;
    
    // Start is called before the first frame update
    void Start() {
        
        // Start the Drop Routine
        StartCoroutine(SpawnBuilding());
    }

    private IEnumerator SpawnBuilding() {
        // which building are we going to drop!?
        int buildingNumber = Random.Range(0, buildingSprites.Length);
        
        // is it a mall? 
        string buildingType;
        if (buildingNumber == 0) {
            buildingType = "Mall";
        }
        else {
            buildingType = "NotaMall";
        }
        
        // where are we going to drop it?
        float x = Random.Range(-8f, 8f);
        Vector3 buildingPos = new Vector3(x, 8, 0);
        
        // Create the Building
        GameObject currentBuilding = Instantiate(building, buildingPos, transform.rotation);
        // Get the SpriteRenderer component
        SpriteRenderer sr = currentBuilding.GetComponent<SpriteRenderer>();
        // set the sprite
        sr.sprite = buildingSprites[buildingNumber];
        // Set the Tag
        currentBuilding.tag = buildingType;

        yield return new WaitForSeconds(1.5f);
        StartCoroutine(SpawnBuilding());
    }
}
