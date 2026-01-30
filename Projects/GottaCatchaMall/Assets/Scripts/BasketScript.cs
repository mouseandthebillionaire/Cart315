using UnityEngine;

public class BasketScript : MonoBehaviour {

	public float basket_x = 0;
	public float speed = .1f;

	public KeyCode left, right;

	public float score;
    
	// Start is called before the first frame update
	void Start() {
		score = 0;
		// Reset Function
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(left) && basket_x > -9f) {
			basket_x -= speed;
            
		}
		if (Input.GetKey(right) && basket_x < 9f) {
			basket_x += speed;
		}

		this.transform.position = new Vector3(
			basket_x, 
			transform.position.y, 
			transform.position.z
		);
	}

	private void OnCollisionEnter2D(Collision2D other) {
		Debug.Log(other.gameObject.tag);

		// Get the value of the building's points
		int pointValue;
		if (other.gameObject.tag == "Mall") pointValue = 1;
		// else if(other.gameObject.tag == "Airport") pointValue = 2;
		else pointValue = -1;

		// Tell the UIManager how much to change the score by
		UIManager.S.UpdateScore(pointValue);
        
		Destroy(other.gameObject);

	}
}