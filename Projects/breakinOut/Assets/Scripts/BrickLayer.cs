using UnityEngine;
using UnityEngine.UIElements;

public class BrickLayer : MonoBehaviour {
    public GameObject brick;
    public int rows, columns;
    public float bs_h, bs_v;

    public Color colorA, colorB;

    
    
    public int numBricks;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        Lay();
    }

    public void Lay() {
        for (int i = 0; i < columns; i++) {
            for (int j = 0; j < rows; j++) {
                float xPos = -columns + (i * bs_h);
                float yPos = rows - (j * bs_v);

                int     value;
                Color c = new Color();
                if (j % 3 == 0) {
                    value = 10;
                    c = colorA;
                }
                else {
                    value = 5;
                    c = colorB;

                }

                GameObject b = Instantiate(brick, new Vector3(xPos, yPos, 0), transform.rotation, this.transform);
                b.GetComponent<BrickScript>().pointValue = value;
                b.GetComponent<SpriteRenderer>().color = c;

            }
        }
    }
}
