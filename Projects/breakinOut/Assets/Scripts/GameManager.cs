using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public int lives;
    public int points;
    public int test;

    public int highScore;

    public Image heartImage;
    

    public static GameManager S;
    
    // Start is called before the first frame update
    void Awake() {
        S = this;

        DontDestroyOnLoad(this.gameObject);
    }

    void Start() {
        lives = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseLife() {
        // Check how many lives are left
        if (lives <= 1) {
            // GameOver
            GameOver();

        }
        else {
            lives -= 1;
            // full life = 1 // 3
            // heartImage.fillAmount = (lives * .2f); 
        }
        
        
    }
    
    public void AddPoint(int numPoints) {
        points += numPoints;
    }

    public void GameOver() {
        if (points > highScore) {
            highScore = points;
        }
        
        SceneManager.LoadScene("GameOver");

    }
}
