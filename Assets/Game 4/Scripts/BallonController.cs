using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonController : MonoBehaviour {
    public GameObject balonExplode;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Projectile_Asam"|| collision.tag == "Projectile_Basa"|| collision.tag == "Projectile_Netral")
        {
            PlayExplosion();
          //  Destroy(this.gameObject);
            
        }
    }

    private void PlayExplosion()
    {
        GameObject explosion = Instantiate(balonExplode);
        explosion.transform.position = transform.position;
    }
    
}
