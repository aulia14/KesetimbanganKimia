using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileResetPos : MonoBehaviour {

	public void Reset () {
		//	The reset function will Reset the game by reloading the same level
	
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
	   transform.position = new Vector3(-16,-5,0);
	}

	void Update()
	{
		Reset();
	}
}
