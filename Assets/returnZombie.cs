using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnZombie : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        zombie target = GetZombie();
        if(target != null)
        Debug.DrawLine(transform.position, GetZombie().transform.position,Color.red,3f );
	}
    zombie GetZombie()
    {
        return (zombie)GameObject.FindObjectOfType(typeof(zombie));
    }
}
