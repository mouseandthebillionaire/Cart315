using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour {
    public int score = 0;

    public TMP_Text scoreText;

    public static UIManager S;

    void Awake() {
        S = this;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        // scoreText.text = "Test";
        UpdateScore(0);
    }

    // Update is called once per frame
    public void UpdateScore(int pointValue)
    {
        // how much are updating the score by?
        int _pointValue = pointValue;
        // add / subtract that value
        score += _pointValue;
        // make that new value a String
        string scoreString = score.ToString();
        // change the scoreText to the new string
        scoreText.text = "Score: " + scoreString;
        
        // scoreText.text = (score += pointValue).ToString();
    }
    
    
}
