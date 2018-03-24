using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileControl : MonoBehaviour {

    public GameObject ASAM_Projectile;
    public GameObject BASA_Projectile;
    public GameObject NETRAL_Projectile;
    public GameObject projectilePos;
    public bool asamCondition = false;
    public bool basaCondition = false;
    public bool netralCondition = false;
    private void Start()
    {
        asamCondition = false;
        basaCondition = false;
        netralCondition = false;
    }
    public void Activate_ASAM(bool benar=true)
    {
        asamCondition = true;
        if (benar == asamCondition)
        {
            ASAM_Projectile.SetActive(true);
            BASA_Projectile.SetActive(false);
            NETRAL_Projectile.SetActive(false);
        }
        else
        {
            ASAM_Projectile.SetActive(false);
            BASA_Projectile.SetActive(false);
            NETRAL_Projectile.SetActive(false);
        }
    }
    public void Activate_BASA(bool benar=true)
    {
        basaCondition = true;
        if (benar == basaCondition)
        {
            ASAM_Projectile.SetActive(false);
            BASA_Projectile.SetActive(true);
            NETRAL_Projectile.SetActive(false);
        }
        else
        {
            ASAM_Projectile.SetActive(false);
            BASA_Projectile.SetActive(false);
            NETRAL_Projectile.SetActive(false);
        }
        
    }
    public void Activate_NETRAL(bool benar=true)
    {
        netralCondition = true;
        if (benar == netralCondition)
        {
            ASAM_Projectile.SetActive(false);
            BASA_Projectile.SetActive(false);
            NETRAL_Projectile.SetActive(true);
        }
        else
        {
            ASAM_Projectile.SetActive(false);
            BASA_Projectile.SetActive(false);
            NETRAL_Projectile.SetActive(false);
        }
    }
    public void Reset () {
		//	The reset function will Reset the game by reloading the same level
	
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
	   transform.position = Vector3.zero;
	}
}
