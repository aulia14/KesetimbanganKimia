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
        ProjectileControl pj = FindObjectOfType<ProjectileControl>();
            pj.Reset();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Projectile_Asam"|| collision.tag == "Projectile_Basa"|| collision.tag == "Projectile_Netral")
        {
            PlayExplosion();
            Destroy(this.gameObject);
            if(this.gameObject.tag =="Balon_Asam"){
                ScoreController2 sc = FindObjectOfType<ScoreController2>();
                sc.addScore(10);
            }else if(this.gameObject.tag =="Balon_Basa"){
                ScoreController2 sc = FindObjectOfType<ScoreController2>();
                sc.addScore(10);
            }else if(this.gameObject.tag =="Balon_Netral"){
                ScoreController2 sc = FindObjectOfType<ScoreController2>();
                sc.addScore(10);
            }else{
                ScoreController2 sc = FindObjectOfType<ScoreController2>();
                sc.minScore(10);
            }
        }
        if(collision.tag == "Projectile_Asam")
        {
            ProjectileControl pj = FindObjectOfType<ProjectileControl>();
            pj.Activate_ASAM(false);
            pj.Reset();
            //PauseGame();
        }
        if(collision.tag == "Projectile_Basa")
        {

            ProjectileControl pj = FindObjectOfType<ProjectileControl>();
            pj.Activate_ASAM(false);
            pj.Reset();
            //PauseGame();
        }
        if(collision.tag == "Projectile_Netral")
        {
            ProjectileControl pj = FindObjectOfType<ProjectileControl>();
            pj.Activate_ASAM(false);
            pj.Reset();
           // PauseGame();
        }
    }
    private void PauseGame(){
        Time.timeScale = -1;
    }
    private void PlayExplosion()
    {
        GameObject explosion = Instantiate(balonExplode);
        explosion.transform.position = transform.position;
    }
    
}
