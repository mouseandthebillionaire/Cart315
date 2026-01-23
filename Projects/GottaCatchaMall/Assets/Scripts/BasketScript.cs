using UnityEngine;

public class BasketScript : MonoBehaviour {

	public float basket_x = 0;
	public float speed = .1f;

	public KeyCode left, right;

	public float score;
    
	// Start is called before the first frame update
	void Start() {
		score = 0;
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

		if (other.gameObject.tag == "Mall") score += 1;
		else score -= 1;
        
		Destroy(other.gameObject);

	}
}