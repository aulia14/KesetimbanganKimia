using UnityEngine;
using System.Collections;

//	Attach this script to the Main Camera.
//	This script will set the transform values for the GameObject it is attached to.
public class ProjectileFollow : MonoBehaviour {

	public Transform projectile_ASAM;        // The transform of the projectile to follow.
    public Transform projectile_BASA;
    public Transform projectile_NETRAL;
    public Transform farLeft;           // The transform representing the left bound of the camera's position.
	public Transform farRight;          // The transform representing the right bound of the camera's position.
    public bool asam = false;
    public bool basa = false;
    public bool netral = false;
    private void Start()
    {
        asam = false;
        basa = false;
        netral = false;
    }
    void Update () {
        bool asam_Ya = projectile_ASAM.gameObject.activeSelf;
        bool basa_Ya = projectile_BASA.gameObject.activeSelf;
        bool netral_Ya = projectile_NETRAL.gameObject.activeSelf;
        // Store the position of the camera.
        // Set the x value of the stored position to that of the bird.
        // Clamp the x value of the stored position between the left and right bounds.
        // Set the camera's position to this stored position.
        if (asam_Ya == !asam)
        {
            AsamFollow();
        }else if(basa_Ya == !basa)
        {
            BasaFollow();
        }else if(netral_Ya == !netral)
        {
            NetralFollow();
        }

    }
    void AsamFollow()
    {
        Vector3 newPositionAsam = transform.position;
        newPositionAsam.x = projectile_ASAM.position.x;
        newPositionAsam.x = Mathf.Clamp(newPositionAsam.x, farLeft.position.x, farRight.position.x);
        transform.position = newPositionAsam;
    }
    void BasaFollow()
    {
        Vector3 newPositionBasa = transform.position;
        newPositionBasa.x = projectile_BASA.position.x;
        newPositionBasa.x = Mathf.Clamp(newPositionBasa.x, farLeft.position.x, farRight.position.x);
        transform.position = newPositionBasa;
    }
    void NetralFollow()
    {
        Vector3 newPositionNetral = transform.position;
        newPositionNetral.x = projectile_NETRAL.position.x;
        newPositionNetral.x = Mathf.Clamp(newPositionNetral.x, farLeft.position.x, farRight.position.x);
        transform.position = newPositionNetral;
    }
}
