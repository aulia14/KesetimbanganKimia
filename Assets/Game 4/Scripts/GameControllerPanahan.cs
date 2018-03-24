using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerPanahan : MonoBehaviour {

	public void PlayAgain(string namaScene){
		SceneManager.LoadScene(namaScene);
	}
	public void Pause(){
		Time.timeScale =-1f;
	}
	public void NextScene(string namaScene){
		SceneManager.LoadScene(namaScene);
	}
}
