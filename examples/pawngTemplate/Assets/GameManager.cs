using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int lives;
    public int points;

    public Image heartImage;

    public static GameManager S;
    
    // Start is called before the first frame update
    void Awake() {
        S = this;
    }

    void Start() {
        lives = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseLife() {
        lives -= 1;
        // full life = 1 // 3
        heartImage.fillAmount = (lives * .2f);
    }
    
    public void AddPoint(int numPoints) {
        points += numPoints;
    }
}
