using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAndPoint : MonoBehaviour {

    public ScoreDisplay SD;
	// Use this for initialization
	void Start () {
        
         SD = GetComponent<ScoreDisplay>();
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Object On me");
       // SD.AddScore(10);
        Destroy(other.gameObject);
    }
}
