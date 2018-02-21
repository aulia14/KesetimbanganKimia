using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllers : MonoBehaviour {
	public float BallSpeed;

	Vector3 position;
	bool currntPlatformAndroid = false;
	Rigidbody2D rb;
	void Awake()
	{
		rb = GetComponent<Rigidbody2D> ();
		#if UNITY_ANDROID
		currntPlatformAndroid = true;
		#else
		currntPlatformAndroid=false;
		#endif
	}

	// Use this for initialization
	void Start () {
		position = transform.position;
		if (currntPlatformAndroid == true){
			Debug.Log ("Android");
		}else{
			Debug.Log("Windows");
		}
	}

	// Update is called once per frame
	void Update () {
		if (currntPlatformAndroid == true) {
			//android specific code
		} else {
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, BallSpeed);

			}
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (BallSpeed, GetComponent<Rigidbody2D> ().velocity.y);

			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (-BallSpeed, GetComponent<Rigidbody2D> ().velocity.y);

			}
		}

	}


	public void Right()
	{
		rb.velocity = new Vector2 (BallSpeed, 0);

	}
	public void Left()
	{
		rb.velocity = new Vector2 (-BallSpeed, 0);
	}
	public void SetVelocityZero()
	{
		rb.velocity = Vector2.zero;
	}

}