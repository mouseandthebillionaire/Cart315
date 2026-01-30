using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour {
    public TMP_Text finalScore;
    public TMP_Text highScore;

    public int number1;
    private int number2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        ShowScore();
    }

    // Update is called once per frame
    void ShowScore() {
        finalScore.text = "Final Score:" + GameManager.S.points;
        
    }

    // public string GetName() {
    //     return
    // }
}
