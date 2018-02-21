using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetunjukScript : MonoBehaviour {
    public GameObject panelPetunjuk;
	// Use this for initialization
	public void klikNext()
    {
        panelPetunjuk.SetActive(false);
    }
}
