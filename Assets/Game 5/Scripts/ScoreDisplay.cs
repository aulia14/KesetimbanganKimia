using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    public int points = 999;
    private Text score;
	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();
        score.text = "Score :" + points; 
	}
	
	// Update is called once per frame
	void Update () {
        
            
      
	}

    public void AddScore(int point)
    {
        points += point;
        score.text = "Score :" + points;
    }
}
