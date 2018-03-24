using UnityEngine;
using System.Collections;

public class clickcontrol : MonoBehaviour {

	public static string nameofobject;
	public GameObject objectnametext;
	public Transform objectnametextPos;
	public Transform succesclick;

	public int randNumb = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (hintmater.hintused == "y")
		{
			randNumb = Random.Range (1,5);

			if ((gameObject.name == "jam") && (randNumb == 1))
			{
				GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
				hintmater.hintused = "n";
			}

			if ((gameObject.name == "trash") && (randNumb == 2))
			{
				GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
				hintmater.hintused = "n";
			}

			if ((gameObject.name == "microscope") && (randNumb == 3))
			{
				GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
				hintmater.hintused = "n";
			}

			if ((gameObject.name == "backpack") && (randNumb == 4))
			{
				GetComponent<SpriteRenderer>().color = new Color (1, 0, 0);
				hintmater.hintused = "n";
			}
		}
	}

	void OnMouseDown()
	{
		nameofobject = gameObject.name;
		//Debug.Log (nameofobject);
		Destroy (gameObject);
		Destroy (objectnametext);
		trackingclicks.totalclicks = 0;
		Instantiate (succesclick, objectnametextPos.position, succesclick.rotation);
	}
}
