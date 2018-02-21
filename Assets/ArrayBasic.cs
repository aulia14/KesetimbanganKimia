using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayBasic : MonoBehaviour {

    void InspectArray(GameObject[,] gos)
    {
        int columns = gos.GetLength(0);
        Debug.Log("Column : " + columns);
        int row = gos.GetLength(1);
        Debug.Log("Row : " + row);
        for(int i = 0; i < columns; i++)
        {
            for(int j = 0; j < row; j++)
            {
                Debug.Log(gos[i, j].name);
            }
        }
    }
	// Use this for initialization
	void Start () {
        GameObject a = new  GameObject("A");
        GameObject b = new GameObject("B");
        GameObject c = new GameObject("C");
        GameObject d = new GameObject("D");
        GameObject e = new GameObject("E");
        GameObject f = new GameObject("F");
        GameObject[,] twoDimension = new GameObject[2, 3] { { a, b, c }, { d, e, f } };
        InspectArray(twoDimension);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
