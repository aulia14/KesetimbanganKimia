using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningFood : MonoBehaviour {
	public GameObject[] Food;
	int FoodNo;
	public float maxPos = 1.9f;
	public float delayTimer = 0.5f;
	float timer;
    

	// Use this for initialization
	void Start () {
		timer = delayTimer;
        
	}
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		if (timer <=0) {
			Vector3 carPos = new Vector3 (Random.Range (-1.9f, 1.9f),transform.position.y, transform.position.z);
			FoodNo = Random.Range (0,16);
			Instantiate (Food[FoodNo], carPos, transform.rotation);
			timer = delayTimer;
		}
	}
}