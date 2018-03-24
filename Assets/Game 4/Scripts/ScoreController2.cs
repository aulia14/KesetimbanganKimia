using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreController2 : MonoBehaviour {
	private int scores;
	ScoreController2(){

	}
	public int GetScore{
		get{
			return scores;
		}
	}
	public void addScore(int score){
		this.scores+= score;
	}
	public void minScore(int score){
		this.scores-= score;
	}
	public Text myScore;
	// Use this for initialization

	void Start () {
		myScore.text = "Score "+scores;
	}
	
	// Update is called once per frame
	void Update () {
		myScore.text = "Score "+scores;
	}
}
